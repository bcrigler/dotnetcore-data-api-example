using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class CrmContactsImports
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
        public byte? Overwrite { get; set; }
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
        public int? NullEmailsCount { get; set; }
        public int? TestPurgedResult { get; set; }
        public DateTimeOffset? TestPurgedTimestamp { get; set; }
        public DateTimeOffset? HolderImportCompletedOn { get; set; }
        public int? TotalHolderSuccess { get; set; }
        public int? TotalHolderFailure { get; set; }
    }
}
