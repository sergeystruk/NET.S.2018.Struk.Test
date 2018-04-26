namespace Task5.Solution
{
    public class ToPlainTextVisitor : IDocumentPartVisitor
    {
        public string PlainTextString { get; private set; }

        public void Visit(HyperLink hyperlink) => PlainTextString = hyperlink.Text + " [" + hyperlink.Url + "]";

        public void Visit(PlainText plainText) => PlainTextString = plainText.Text;

        public void Visit(BoldText boldText) => PlainTextString = "**" + boldText.Text + "**";
    }
}