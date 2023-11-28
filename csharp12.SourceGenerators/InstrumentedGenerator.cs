using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace csharp12.SourceGenerators;

[Generator]
public class InstrumentedGenerator : ISourceGenerator
{
    public void Execute(GeneratorExecutionContext context)
    {
        if (context.SyntaxContextReceiver is not InstrumentedSyntaxReceiver receiver)
        {
            return;
        }
    }

    public void Initialize(GeneratorInitializationContext context)
    {
        context.RegisterForSyntaxNotifications(() => new InstrumentedSyntaxReceiver());
    }

    class InstrumentedSyntaxReceiver : ISyntaxContextReceiver
    {
        public List<INamedTypeSymbol> MethodsToInstrument { get; } = [];

        public void OnVisitSyntaxNode(GeneratorSyntaxContext context)
        {
            if (context.Node is ClassDeclarationSyntax classDeclarationSyntax
                && classDeclarationSyntax.AttributeLists.Count > 0)
            {
                var symbol = context.SemanticModel.GetDeclaredSymbol(classDeclarationSyntax) as INamedTypeSymbol;
                if (symbol is not null
                    && symbol.GetAttributes().Any(x => x.AttributeClass?.ToDisplayString() == "MapFrom.MapFromAttribute"))
                {
                    MethodsToInstrument.Add(symbol);
                }
            }
        }
    }
}
