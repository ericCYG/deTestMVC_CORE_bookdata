using deTestMVC_CORE_bookdata.Models;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace deTestMVC_CORE_bookdata;

public partial class CBookDatumViewModel
{

    private BookDatum _BookDatum;

    public CBookDatumViewModel( ) {
        _BookDatum = new BookDatum();
    }

    public BookDatum bookDatum
    {
        get { return _BookDatum; }
        set { _BookDatum = value; }
    }
   
    public int BookId { get { return _BookDatum.BookId; } }
    [DisplayName("書名")]
    public string BookName { get { return _BookDatum.BookName; } set {  _BookDatum.BookName = value; } }
    [DisplayName("圖書類別")]
    public string BookClassId { get { return _BookDatum.BookClassId; } set {  _BookDatum.BookClassId = value; } }

    public string? BookAuthor { get { return _BookDatum.BookAuthor; } set { _BookDatum.BookAuthor = value; } }
    [DisplayName("購書日期")]
    [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}")]
    public DateTime? BookBoughtDate { get { return _BookDatum.BookBoughtDate; } set { _BookDatum.BookBoughtDate = value; } }

    public string? BookPublisher { get { return _BookDatum.BookPublisher; } set { _BookDatum.BookPublisher = value; } }

    public string? BookNote { get { return _BookDatum.BookNote; } set { _BookDatum.BookNote = value; } }
    [DisplayName("借閱狀態")]
    public string BookStatus { get { return _BookDatum.BookStatus; } set { _BookDatum.BookStatus = value; } }
    [DisplayName("借閱人")]
    public string? BookKeeper { get { return _BookDatum.BookKeeper; } set { _BookDatum.BookKeeper = value; } }

    public int? BookAmount { get { return _BookDatum.BookAmount; } set { _BookDatum.BookAmount = value; } }

    public DateTime? CreateDate { get { return _BookDatum.CreateDate; } set { _BookDatum.CreateDate = value; } }

    public string? CreateUser { get { return _BookDatum.CreateUser; } set { _BookDatum.CreateUser = value; } }

    public DateTime? ModifyDate { get { return _BookDatum.ModifyDate; } set { _BookDatum.ModifyDate = value; } }

    public string? ModifyUser { get { return _BookDatum.ModifyUser; } set { _BookDatum.ModifyUser = value; } }
}
