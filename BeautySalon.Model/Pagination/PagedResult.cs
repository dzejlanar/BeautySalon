namespace BeautySalon.Model.Pagination
{
    public class PagedResult<T>
    {
        public List<T>? contentItems { get; set; }
        public int totalItems { get; set; }
    }
}
