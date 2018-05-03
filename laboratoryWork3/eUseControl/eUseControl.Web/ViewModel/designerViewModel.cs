using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using eUseControl.Web.Models;

namespace eUseControl.Web.ViewModels
{
    public class designerViewModel
    {
        public IEnumerable<StyleTypes> StyleTypes { get; set; }
        public userInfo User { get; set; }
    }
}