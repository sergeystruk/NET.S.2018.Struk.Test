namespace Task5.Solution
{
    public static class DocumentPartExtensions
    {
        public static string ToHtml(this DocumentPart part)
        {
            var visitor = new ToHtmlVisitor();
            part.Accept(visitor);
            return visitor.HtmlText;
        }

        public static string ToPlainText(this DocumentPart part)
        {
            var visitor = new ToPlainTextVisitor();
            part.Accept(visitor);
            return visitor.PlainTextString;
        }

        public static string ToLaTeX(this DocumentPart part)
        {
            var visitor = new ToLaTeXVisitor();
            part.Accept(visitor);
            return visitor.LaTeX;
        }
    }
}