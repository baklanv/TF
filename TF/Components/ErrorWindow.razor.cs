using System.Threading;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;
using TF.Resources;
using TF.Services;

namespace TF.Components
{
    public partial class ErrorWindow
    {
        [Inject]
        public IErrorTransmitter ErrorTransmitter { get; set; }

        //[Inject]
        //public IStringLocalizer<PageResource> PageLocalizer { get; set; }

        private ModalWindow _modalWindow;

        private string _title;

        private string _errorMessage;

        private string[] _stackTrace;

        protected override void OnInitialized()
        {
            base.OnInitialized();
            ErrorTransmitter.RefreshUI = RefreshUI;
        }

        public void RefreshUI(string title, string errorMessage, string[] stackTrace)
        {
            _title = title;
            _errorMessage = errorMessage;
            _stackTrace = stackTrace;
            InvokeAsync(StateHasChanged);
            _modalWindow.Open();
            var timer = new Timer(_ =>
            {
                _modalWindow.Close();
            }, null, 5000, 0);
        }
    }
}
