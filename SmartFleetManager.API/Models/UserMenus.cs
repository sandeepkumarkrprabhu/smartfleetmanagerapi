namespace SmartFleetManager.API.Models
{
    public class UserMenu
    {
        public string MenuId {get;set; }
        
        public string label {get;set; }
                
        public string UserId {get;set; }

        public string href {get;set; }

        public string icon {get;set; }
        public string groupName {get;set; }
        public int order {get;set; }
        
    }
}
