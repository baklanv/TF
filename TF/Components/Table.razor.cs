using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Microsoft.AspNetCore.Components;

namespace TF.Components
{
    public partial class Table<TItem>
    {
        [Parameter]
        public RenderFragment TableHeader { get; set; }

        [Parameter]
        public RenderFragment<TItem> RowTemplate { get; set; }

        [Parameter][DisallowNull]
        public IEnumerable<TItem> Items { get; set; }
    }
}
