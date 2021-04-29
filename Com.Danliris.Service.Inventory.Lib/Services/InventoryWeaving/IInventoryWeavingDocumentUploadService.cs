﻿using Com.Danliris.Service.Inventory.Lib.Helpers;
using Com.Danliris.Service.Inventory.Lib.Models.InventoryWeavingModel;
using Com.Danliris.Service.Inventory.Lib.ViewModels.InventoryWeavingViewModel;
using Microsoft.Extensions.Primitives;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Com.Danliris.Service.Inventory.Lib.Services.InventoryWeaving
{
    public interface IInventoryWeavingDocumentUploadService
    {
        Tuple<bool, List<object>> UploadValidate(ref List<InventoryWeavingDocumentCsvViewModel> Data, List<KeyValuePair<string, StringValues>> Body);
        List<string> CsvHeader { get; }
        Task UploadData(InventoryWeavingDocument data, string username);
        InventoryWeavingDocumentDetailViewModel ReadById(int id);
        ReadResponse<InventoryWeavingDocument> Read(int page, int size, string order, string keyword, string filter);
        Task<InventoryWeavingDocument> MapToModel(InventoryWeavingDocumentViewModel data);
        //Task<InventoryWeavingMovement> MapToModelMovement(InventoryWeavingDocumentViewModel data);
        Task<InventoryWeavingDocumentViewModel> MapToViewModel(List<InventoryWeavingDocumentCsvViewModel> data, DateTimeOffset date, string From);
    }
}