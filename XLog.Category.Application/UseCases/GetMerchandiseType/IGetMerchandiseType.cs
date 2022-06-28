using System.Collections.Generic;

namespace XLog.Category.Application.UseCases.GetMerchandiseType
{
    public interface IGetMerchandiseType
    {
        public string MerchandiseTypeID { get; }

    }   

    public class AddMerchandiseTypeItem
    {
        public string? Id { get; set; }
        public string? Description { get; set; }
        public string? MerchandiseDescription { get; set;}
        public string? IDService { get; set;}
        public int Active { get; set;}
    }
    public interface ICreateMerchandiseType
    {
        public IEnumerable<AddMerchandiseTypeItem> merchandiseTypeItems {get;}
    }
    public class UpdateMerchandiseTypeItem
    {
        public string? Id { get; set; }
        public string? Description { get; set; }
        public string? MerchandiseDescription { get; set;}
        public string? IDService { get; set;}
        public int Active { get; set;}
    }
    public interface IUpdateMerchandiseType
    {
        public IEnumerable<UpdateMerchandiseTypeItem> merchandiseTypes {get;}
    }
    public interface IDeleteMerchandiseType
    {
        public string merchandiseTypeID { get; }
    }
}