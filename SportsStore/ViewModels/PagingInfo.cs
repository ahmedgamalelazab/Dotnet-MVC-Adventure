

using System;

namespace SportsStore.ViewModels {

    public class PagingInfo {
        //how many items in the repository 
        public int TotalItems {set;get;}
        //how many items available per page 
        public int ItemsPerPage {get;set;}
        public int CurrentPage { get; set; }

        public int TotalPages => (int)Math.Ceiling((decimal)TotalItems/ItemsPerPage);
    }



}