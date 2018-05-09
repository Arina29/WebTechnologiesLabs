using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using eUseControl.Models;

namespace eUseControl.ViewModels
{
    public class designerViewModel
    {
        public IEnumerable<StyleTypes> StyleTypes { get; set; }
        public userInfo User { get; set; }
    }
}