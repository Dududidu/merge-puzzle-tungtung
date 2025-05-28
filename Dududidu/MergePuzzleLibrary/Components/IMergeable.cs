namespace MergePuzzle.Components
{
    internal interface IMergeable
    {
        public bool IsMergeable { get; set; }
        public void Merge();
    }
}
