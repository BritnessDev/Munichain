﻿// <auto-generated />
using System;
using Data.DatabaseServices;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Data.Migrations
{
    [DbContext(typeof(SqlDbContext))]
    partial class SqlDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Domain.Models.DealComponents.AnnotationComment", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CreatedById")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedByUserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("CreatedTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("DocumentAnnotationId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DocumentAnnotationId");

                    b.ToTable("AnnotationComment");
                });

            modelBuilder.Entity("Domain.Models.DealComponents.DocumentAnnotation", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Author")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedById")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("CreatedTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("DocumentID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsPublished")
                        .HasColumnType("bit");

                    b.Property<int?>("PageNumber")
                        .HasColumnType("int");

                    b.Property<string>("TextMarkupContent")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Annotations");
                });

            modelBuilder.Entity("Shared.Models.AppComponents.Firm", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Bio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("Confirmed")
                        .HasColumnType("bit");

                    b.Property<int?>("FirmType")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("State")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Firm");
                });

            modelBuilder.Entity("Shared.Models.AppComponents.FirmMember", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("EmailAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirmId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("bit");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FirmId");

                    b.ToTable("FirmMember");
                });

            modelBuilder.Entity("Shared.Models.AppComponents.Notification", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("Action")
                        .HasColumnType("int");

                    b.Property<string>("ActionBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ActionDateTimeUTC")
                        .HasColumnType("datetime2");

                    b.Property<string>("DealDesc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DealId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DealParticipant")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DealRole")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DealSize")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DealState")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DocumentId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DocumentName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExpenditureField")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExpenditureValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirmMember")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirmName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsUserRead")
                        .HasColumnType("bit");

                    b.Property<string>("NewObject")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NotifyTo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OldObject")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OldRole")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PropertyChanged")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TopAccount")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("TopAccountMaturityDateUTC")
                        .HasColumnType("datetime2");

                    b.Property<string>("TopAccountParAmount")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Notifications");
                });

            modelBuilder.Entity("Shared.Models.Chat.ChatMessage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DateSentUTC")
                        .HasColumnType("datetime2");

                    b.Property<string>("FromUserDisplayName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FromUserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ToConversationId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("ChatMessages");
                });

            modelBuilder.Entity("Shared.Models.Chat.Conversation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ConversationReadByMembers")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreatedUTC")
                        .HasColumnType("datetime2");

                    b.Property<string>("MemberDisplayNames")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MemberEmails")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MemberIds")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Conversations");
                });

            modelBuilder.Entity("Shared.Models.DealComponents.AppointmentData", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CategoryColor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DealModelId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("EndTimezone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsAllDay")
                        .HasColumnType("bit");

                    b.Property<bool>("IsReadonly")
                        .HasColumnType("bit");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RecurrenceException")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RecurrenceID")
                        .HasColumnType("int");

                    b.Property<string>("RecurrenceRule")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("StartTimezone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Subject")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AppointmentData");
                });

            modelBuilder.Entity("Shared.Models.DealComponents.BoardMessage", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("DateGivenUTC")
                        .HasColumnType("datetime2");

                    b.Property<string>("DealId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GivenByName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GivenByUserId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Message")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("BoardMessages");
                });

            modelBuilder.Entity("Shared.Models.DealComponents.DealExpenditure", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("DealModelId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DisplayName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsOther")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("Value")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ID");

                    b.ToTable("DealExpenditure");
                });

            modelBuilder.Entity("Shared.Models.DealComponents.DealModel", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CUSIP6")
                        .HasMaxLength(6)
                        .HasColumnType("nvarchar(6)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDateUTC")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HistoryDealID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("IsLocked")
                        .HasColumnType("bit");

                    b.Property<string>("Issuer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IssuerURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastModifiedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastModifiedByDisplayName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastModifiedDateTimeUTC")
                        .HasColumnType("datetime2");

                    b.Property<string>("OfferingType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OldStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<DateTime?>("SaleDateUTC")
                        .HasColumnType("datetime2");

                    b.Property<decimal?>("Size")
                        .IsRequired()
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("State")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Deals");
                });

            modelBuilder.Entity("Shared.Models.DealComponents.DealParticipant", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DateAddedUTC")
                        .HasColumnType("datetime2");

                    b.Property<string>("DealId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DealPermissions")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmailAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("IsPublic")
                        .HasColumnType("bit");

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("DealParticipants");
                });

            modelBuilder.Entity("Shared.Models.DealComponents.Document", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedByFullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedDateTimeUTC")
                        .HasColumnType("datetime2");

                    b.Property<string>("DealId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PublicDocumentViewSettings")
                        .HasColumnType("int");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserPermissions")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Documents");
                });

            modelBuilder.Entity("Shared.Models.DealComponents.Maturity", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CUSIP9LastThree")
                        .HasMaxLength(3)
                        .HasColumnType("nvarchar(3)");

                    b.Property<DateTime?>("CallDateUTC")
                        .HasColumnType("datetime2");

                    b.Property<decimal?>("CallPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("CallType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("Coupon")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("CreatedDateUTC")
                        .HasColumnType("datetime2");

                    b.Property<decimal?>("DollarYield")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("GlobalMaturityID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HistoryMaturityID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsTermed")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("MaturityDateUTC")
                        .HasColumnType("datetime2");

                    b.Property<decimal?>("Par")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("SeriesId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("TermId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("Yield")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("YieldDenom")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("SeriesId");

                    b.ToTable("Maturity");
                });

            modelBuilder.Entity("Shared.Models.DealComponents.Performance", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("AverageCoupon")
                        .HasColumnType("int");

                    b.Property<int?>("AverageLife")
                        .HasColumnType("int");

                    b.Property<decimal?>("Bid")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("BidPercentage")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("BondYearDollars")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("CreatedDateUTC")
                        .HasColumnType("datetime2");

                    b.Property<string>("DealModelId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<decimal?>("GrossProduction")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("GrossSpread")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("HistoryPerformanceID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("NIC")
                        .HasColumnType("int");

                    b.Property<decimal?>("ParAmountBonds")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("ReofferingPremium")
                        .HasColumnType("decimal(18,2)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<int?>("TIC")
                        .HasColumnType("int");

                    b.Property<decimal?>("Takedown")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("TotalInstitutionalPar")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("TotalRetailPar")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("TotalUnderwriterDiscount")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("DealModelId")
                        .IsUnique()
                        .HasFilter("[DealModelId] IS NOT NULL");

                    b.ToTable("Performance");
                });

            modelBuilder.Entity("Shared.Models.DealComponents.Reference", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("DateGivenUTC")
                        .HasColumnType("datetime2");

                    b.Property<string>("DealId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirmId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GivenBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Message")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Reference");
                });

            modelBuilder.Entity("Shared.Models.DealComponents.Series", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedDateUTC")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DatedDateUTC")
                        .HasColumnType("datetime2");

                    b.Property<string>("DealModelId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("DeliveryDateUTC")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ESGCertifiedType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ESGVerifier")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FitchRating")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GlobalSeriesID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HistorySeriesID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("IsBankQualified")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsERP")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPublished")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPublishedMaturities")
                        .HasColumnType("bit");

                    b.Property<string>("KrollRating")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LeadManager")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MoodysRating")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Purpose")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SPRating")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("SaleTimeUTC")
                        .HasColumnType("datetime2");

                    b.Property<string>("SecurityType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("SettlementDateUTC")
                        .HasColumnType("datetime2");

                    b.Property<decimal?>("Size")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("SourceOfRepayment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TaxStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TimeZone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DealModelId");

                    b.ToTable("Series");
                });

            modelBuilder.Entity("Shared.Models.DealComponents.TopAccount", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AccountName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDateUTC")
                        .HasColumnType("datetime2");

                    b.Property<string>("HistoryTopAccountID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("MaturityDateUTC")
                        .HasColumnType("datetime2");

                    b.Property<decimal?>("ParAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("PerformanceId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("PerformanceId");

                    b.ToTable("TopAccount");
                });

            modelBuilder.Entity("Shared.Models.Users.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AreasOfExpertise")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Bio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("Confirmed")
                        .HasColumnType("bit");

                    b.Property<string>("DisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JobTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostalCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StateValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TimeZone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Shared.Models.Users.UserNotificationPreference", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("ID"), 1L, 1);

                    b.Property<bool>("Commented")
                        .HasColumnType("bit");

                    b.Property<bool>("Completed")
                        .HasColumnType("bit");

                    b.Property<bool>("Deal")
                        .HasColumnType("bit");

                    b.Property<bool>("Declined")
                        .HasColumnType("bit");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<bool>("Document")
                        .HasColumnType("bit");

                    b.Property<bool>("DocumentAnnotationAdded")
                        .HasColumnType("bit");

                    b.Property<bool>("DocumentAnnotationChanged")
                        .HasColumnType("bit");

                    b.Property<bool>("DocumentAnnotationCommentAdded")
                        .HasColumnType("bit");

                    b.Property<bool>("DocumentCommented")
                        .HasColumnType("bit");

                    b.Property<bool>("DocumentParticipant")
                        .HasColumnType("bit");

                    b.Property<bool>("Expenditure")
                        .HasColumnType("bit");

                    b.Property<bool>("Expired")
                        .HasColumnType("bit");

                    b.Property<bool>("Firm")
                        .HasColumnType("bit");

                    b.Property<bool>("MessageBoardComment")
                        .HasColumnType("bit");

                    b.Property<bool>("Opened")
                        .HasColumnType("bit");

                    b.Property<bool>("Participant")
                        .HasColumnType("bit");

                    b.Property<bool>("Performance")
                        .HasColumnType("bit");

                    b.Property<bool>("Reassigned")
                        .HasColumnType("bit");

                    b.Property<bool>("Revoked")
                        .HasColumnType("bit");

                    b.Property<bool>("Saved")
                        .HasColumnType("bit");

                    b.Property<bool>("Sent")
                        .HasColumnType("bit");

                    b.Property<bool>("Shared")
                        .HasColumnType("bit");

                    b.Property<bool>("Signed")
                        .HasColumnType("bit");

                    b.Property<bool>("Uploaded")
                        .HasColumnType("bit");

                    b.Property<string>("UserID")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("UserNotificationPreference");
                });

            modelBuilder.Entity("Domain.Models.DealComponents.AnnotationComment", b =>
                {
                    b.HasOne("Domain.Models.DealComponents.DocumentAnnotation", null)
                        .WithMany("Comments")
                        .HasForeignKey("DocumentAnnotationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Shared.Models.AppComponents.FirmMember", b =>
                {
                    b.HasOne("Shared.Models.AppComponents.Firm", null)
                        .WithMany("Members")
                        .HasForeignKey("FirmId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Shared.Models.DealComponents.Maturity", b =>
                {
                    b.HasOne("Shared.Models.DealComponents.Series", null)
                        .WithMany("Maturities")
                        .HasForeignKey("SeriesId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Shared.Models.DealComponents.Performance", b =>
                {
                    b.HasOne("Shared.Models.DealComponents.DealModel", null)
                        .WithOne("Performance")
                        .HasForeignKey("Shared.Models.DealComponents.Performance", "DealModelId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Shared.Models.DealComponents.Series", b =>
                {
                    b.HasOne("Shared.Models.DealComponents.DealModel", null)
                        .WithMany("Series")
                        .HasForeignKey("DealModelId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Shared.Models.DealComponents.TopAccount", b =>
                {
                    b.HasOne("Shared.Models.DealComponents.Performance", null)
                        .WithMany("TopAccountList")
                        .HasForeignKey("PerformanceId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Domain.Models.DealComponents.DocumentAnnotation", b =>
                {
                    b.Navigation("Comments");
                });

            modelBuilder.Entity("Shared.Models.AppComponents.Firm", b =>
                {
                    b.Navigation("Members");
                });

            modelBuilder.Entity("Shared.Models.DealComponents.DealModel", b =>
                {
                    b.Navigation("Performance");

                    b.Navigation("Series");
                });

            modelBuilder.Entity("Shared.Models.DealComponents.Performance", b =>
                {
                    b.Navigation("TopAccountList");
                });

            modelBuilder.Entity("Shared.Models.DealComponents.Series", b =>
                {
                    b.Navigation("Maturities");
                });
#pragma warning restore 612, 618
        }
    }
}
