using System;
using System.Collections.Generic;

namespace XLog.Category.Application.UseCases.GetUserGroup
{
    public interface IGetAllUserGroup
    {
        
    }
    public class AddUserGroupItem
    {
        public string Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set;}
        public string Name2 { get; set;}
        public string Note { get; set;}
        public string IsActive { get; set;}
    }
    public interface ICreateUserGroup
    {
        public IEnumerable<AddUserGroupItem> userGroupItems {get;}
    }
    public class UpdateUserGroupItem
    {
        public string Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set;}
        public string Name2 { get; set;}
        public string Note { get; set;}
        public string IsActive { get; set;}
    }
    public interface IUpdateUserGroup
    {
        public IEnumerable<UpdateUserGroupItem> userGroups {get;}
    }
    public interface IDeleteUserGroup
    {
        public string userGroupID { get; }
    }
}
