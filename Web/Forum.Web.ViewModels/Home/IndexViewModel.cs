namespace Forum.Web.ViewModels.Home
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class IndexViewModel
    {
        public IEnumerable<IndexCategoryViewModel> Categories { get; set; }

        public IEnumerable<IndexNumberOneViewModel> TestNumberOnes { get; set; }

        public IEnumerable<IndexNumberTwoViewModel> TestNumberTwos { get; set; }
    }
}
