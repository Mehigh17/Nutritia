using Nutritia.Factories;
using Nutritia.Models;
using Nutritia.Repositories;
using Nutritia.Services;
using Nutritia.Views;
using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Nutritia.ViewModels
{
    public class HomeViewModel : PageViewModel
    {

        private ObservableCollection<ProductRecordViewModel> _productRecords = new ObservableCollection<ProductRecordViewModel>();
        public ObservableCollection<ProductRecordViewModel> ProductRecords
        {
            get => _productRecords;
            set => SetProperty(ref _productRecords, value);
        }

        private readonly IRecordRepository _recordRepo;
        private readonly IRequestExecuter _requestExecuter;
        private readonly IViewModelFactory _viewModelFactory;
        private readonly IModalService _modalService;

        public HomeViewModel()
        {
            _recordRepo = DependencyService.Resolve<IRecordRepository>() ?? throw new ArgumentNullException(nameof(_recordRepo));
            _requestExecuter = DependencyService.Resolve<RequestExecuter>() ?? throw new ArgumentNullException(nameof(_requestExecuter));
            _viewModelFactory = DependencyService.Resolve<IViewModelFactory>() ?? throw new ArgumentNullException(nameof(_viewModelFactory));
            _modalService = DependencyService.Resolve<IModalService>() ?? throw new ArgumentNullException(nameof(_modalService));

            Title = "Home";

            MessagingCenter.Subscribe<HomePage, string>(this, "BarcodeScanned", async (s, c) => await OnBarcodeReceived(c));

            var records = _recordRepo.GetRecords();
            records.ForEach(async (r) =>
            {
                var product = await _requestExecuter.GetProduct(r.Bardcode);
                var vm = _viewModelFactory.CreateProductRecordViewModel(r, product);
                ProductRecords.Add(vm);
            });
        }

        private async Task OnBarcodeReceived(string barcode)
        {
            if (!string.IsNullOrEmpty(barcode))
            {
                IsBusy = true;
                try
                {
                    var product = await _requestExecuter.GetProduct(barcode);
                    var record = new ProductRecord
                    {
                        Bardcode = barcode,
                        SearchedOn = DateTime.Now
                    };
                    _recordRepo.AddRecord(record);
                    var vm = _viewModelFactory.CreateProductRecordViewModel(record, product);
                    ProductRecords.Add(vm);

                    var detailVm = _viewModelFactory.CreateProductDetailViewModel(product);
                    await _modalService.ShowProductDetail(detailVm);
                }
                catch (Exception e)
                {
                    throw e;
                }
                finally
                {
                    IsBusy = false;
                }
            }
        }

    }
}
