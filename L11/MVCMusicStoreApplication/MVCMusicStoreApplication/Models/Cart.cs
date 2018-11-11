using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVCMusicStoreApplication.Models
{
    public class Cart
    {
        [Key]
        public int RecordID { get; set; } //PK override because EF will see CardID as PK
        public string CartID { get; set; } //entitly framework automatically creates PK if propery has ClassnameId
        public int AlbumId { get; set;}
        public int Count { get; set; }
        public DateTime DateCreated { get; set; }
        public virtual Album AlbumSelected { get; set; } //must be virtual bc lazy loading
    }
}