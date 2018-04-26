namespace Task5.Solution
{
    public interface IDocumentPartVisitor
    {
        void Visit(HyperLink hyperlink);
        void Visit(PlainText plainText);
        void Visit(BoldText boldText);
    }
}