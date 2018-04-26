namespace Task5.Solution
{
    public class ToHtmlVisitor : IDocumentPartVisitor
    {
        public string HtmlText { get; private set; }

        public void Visit(HyperLink hyperlink) => HtmlText = "<a href=\"" + hyperlink.Url + "\">" + hyperlink.Text + "</a>";

        public void Visit(PlainText plainText) => HtmlText = plainText.Text;

        public void Visit(BoldText boldText) => HtmlText = "<b>" + boldText.Text + "</b>";
    }
}