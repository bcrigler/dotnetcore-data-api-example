using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class MlsPrivateListings
    {
        public string OrgId { get; set; }
        public int ListingId { get; set; }
        public string AdCityName { get; set; }
        public string AdCountyCode { get; set; }
        public float InLatitude { get; set; }
        public float InLongitude { get; set; }
        public string AdNeighborhood { get; set; }
        public string AdState { get; set; }
        public string AdStreetDesignator { get; set; }
        public string AdStreetDirection { get; set; }
        public string AdStreetPostDir { get; set; }
        public string AdStreetName { get; set; }
        public int? AdStreetNumber { get; set; }
        public string AdUnit { get; set; }
        public string AdZipCode { get; set; }
        public string AgCoagentId { get; set; }
        public string AgCoagentName { get; set; }
        public string AgCoagentPhone { get; set; }
        public string AgEmail { get; set; }
        public string AgId { get; set; }
        public string AgMobilePhone { get; set; }
        public string AgName { get; set; }
        public string AgOfficeId { get; set; }
        public string AgOfficeName { get; set; }
        public string AgOfficePhone { get; set; }
        public string AgPhone { get; set; }
        public string AgReciprocalLink { get; set; }
        public decimal? ExLotSizeAcres { get; set; }
        public int? ExLotSizeSquareFeet { get; set; }
        public decimal? FiTaxAmount { get; set; }
        public byte? InImageCount { get; set; }
        public decimal? InListPrice { get; set; }
        public decimal? InSoldPrice { get; set; }
        public string InPublicRemarks { get; set; }
        public string InStatus { get; set; }
        public string InVirtualTourLink { get; set; }
        public string InDetailUrl { get; set; }
        public string ScElementarySchool { get; set; }
        public string ScHighSchool { get; set; }
        public string ScJuniorHighSchool { get; set; }
        public string ScSchoolDistrict { get; set; }
        public string ListOnInternetYn { get; set; }
        public string DisplayAddressYn { get; set; }
        public int? InLivingSquareFeet { get; set; }
        public short? InYearBuilt { get; set; }
        public byte RmBathsFull { get; set; }
        public byte RmBathsHalf { get; set; }
        public byte RmBathsQuarter { get; set; }
        public byte RmBathsThreeQuarter { get; set; }
        public decimal? RmBathsTotal { get; set; }
        public byte? RmBedroomsTotal { get; set; }
        public int PublishStatus { get; set; }
        public DateTimeOffset LastUpdate { get; set; }
        public int UserId { get; set; }
        public int PoTourId { get; set; }
    }
}
