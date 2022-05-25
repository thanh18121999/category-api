namespace XLog.Category.Application.UseCases.SearchPartners
{
    public interface ISearchPartners
    {
        public string Filter { get; }

        public int PageIndex { get; }

        public int PageSize { get; }
    }
}
