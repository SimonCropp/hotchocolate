using HotChocolate.Types;

namespace HotChocolate.Data.Neo4J.Analyzers.Types
{
    public class OperationDirectiveType : DirectiveType<OperationDirective>
    {
        protected override void Configure(IDirectiveTypeDescriptor<OperationDirective> descriptor)
        {
            descriptor
                .Name("operation")
                .Location(DirectiveLocation.Object | DirectiveLocation.Schema);

            descriptor
                .Argument(t => t.Operations)
                .Type<ListType<NonNullType<OperationKindType>>>();
        }
    }
}
