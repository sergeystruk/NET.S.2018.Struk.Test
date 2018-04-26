namespace Task5.Solution
{
    public abstract class DocumentPart
    {
        public string Text { get; set; }
        
        public void Accept(IDocumentPartVisitor visitor)
        {
            visitor.Visit((dynamic)this);
        }
    }
}