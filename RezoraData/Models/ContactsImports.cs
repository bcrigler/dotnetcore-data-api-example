using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class ContactsImports
    {
        public int ImportId { get; set; }
        public int UserId { get; set; }
        public DateTimeOffset SubmittedTimestamp { get; set; }
        public DateTimeOffset? CompletedTimestamp { get; set; }
        public int SubmittedCount { get; set; }
        public int? MergedCount { get; set; }
        public string ImportPath { get; set; }
        public byte ImportStatus { get; set; }
        public byte? ImportError { get; set; }
        public int ListId { get; set; }
        public byte? Overwrite { get; set; }
        public string HeaderType { get; set; }
        public DateTimeOffset? TestHeadersTimestamp { get; set; }
        public int? TestHeadersResult { get; set; }
        public DateTimeOffset? TestDuplicatesTimestamp { get; set; }
        public int TestDuplicatesResult { get; set; }
        public DateTimeOffset? TestExistsTimestamp { get; set; }
        public int TestExistsResult { get; set; }
        public DateTimeOffset? TestUnsubscribesTimestamp { get; set; }
        public int TestUnsubscribesResult { get; set; }
        public DateTimeOffset? TestBouncesTimestamp { get; set; }
        public int TestBouncesResult { get; set; }
        public DateTimeOffset? TestSpamTimestamp { get; set; }
        public int TestSpamResult { get; set; }
        public DateTimeOffset? TestDeliveredTimestamp { get; set; }
        public int TestDeliveredResult { get; set; }
        public DateTimeOffset? TestVerifiedTimestamp { get; set; }
        public int TestVerifiedResult { get; set; }
        public DateTimeOffset? TestSyntaxTimestamp { get; set; }
        public int TestSyntaxResult { get; set; }
        public DateTimeOffset? TestSmtpTimestamp { get; set; }
        public int TestSmtpResult { get; set; }
        public DateTimeOffset? TestGdprTimestamp { get; set; }
        public int TestGdprResult { get; set; }
    }
}
