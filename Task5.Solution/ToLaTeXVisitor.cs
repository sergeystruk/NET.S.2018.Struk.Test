namespace Task5.Solution
{
    public class ToLaTeXVisitor : IDocumentPartVisitor
    {
        public string LaTeX { get; private set; }

        public void Visit(HyperLink hyperlink) => LaTeX = "\\href{" + hyperlink.Url + "}{" + hyperlink.Text + "}";

        public void Visit(PlainText plainText) => LaTeX = plainText.Text;

        public void Visit(BoldText boldText) => LaTeX = "\\textbf{" + boldText.Text + "}";
    }
}