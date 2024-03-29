﻿USE [MH_InternalDB]
GO

/****** Object:  Table [Schema].[Test02]    Script Date: 2/22/2022 7:07:54 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[TestPEF1](
	[Id] [int] IDENTITY(1,1)  NOT NULL,
	[ProvNPI] [int] NOT NULL,
	[ProvIdofNCTracks] [varchar](8000) NULL,
	[ProvEnrollmentType] [varchar](8000) NULL,
	[ProvSSN] [varchar](8000) NULL,
	[ProvTaxId] [varchar](8000) NULL,
	[ProvLastname] [varchar](8000) NULL,
	[ProvFirstname] [varchar](8000) NULL,
	[ProvMiddleName] [varchar](8000) NULL,
	[ProvGender] [varchar](8000) NULL,
	[ProvDOB] [varchar](8000) NULL,
	[VendorName] [varchar](8000) NULL,
	[EffectiveDate] [varchar](8000) NULL,
	[EndDate] [varchar](8000) NULL,
	[MailingAddress1] [varchar](8000) NULL,
	[MailingAddress2] [varchar](8000) NULL,
	[MailingCity] [varchar](8000) NULL,
	[MailingState] [varchar](8000) NULL,
	[MailingZip] [varchar](8000) NULL,
	[ContractClass] [varchar](8000) NULL,
	[ContractEffectiveDate] [varchar](8000) NULL,
	[ContractEndDate] [varchar](8000) NULL,
	[ContractClassPrev01] [varchar](8000) NULL,
	[ContractEffDatePrev01] [varchar](8000) NULL,
	[ContractEndDatePrev01] [varchar](8000) NULL,
	[ContractClassPrev02] [varchar](8000) NULL,
	[ContractEffDatePrev02] [varchar](8000) NULL,
	[ContractEndDatePrev02] [varchar](8000) NULL,
	[CustAttRetrodateTrigger] [varchar](8000) NULL,
	[HCContractClass] [varchar](8000) NULL,
	[HCContractEffDate] [varchar](8000) NULL,
	[HCContractEndDate] [varchar](8000) NULL,
	[HCContractClassPrev01] [varchar](8000) NULL,
	[HCContractEffDatePrev01] [varchar](8000) NULL,
	[HCContractEndDatePrev01] [varchar](8000) NULL,
	[HCContractClassPrev02] [varchar](8000) NULL,
	[HCContractEffDatePrev02] [varchar](8000) NULL,
	[HCContractEndDatePrev02] [varchar](8000) NULL,
	[HCCustAttRetrodateTrigger] [varchar](8000) NULL,
	[OfcAdminLastname] [varchar](8000) NULL,
	[OfcAdminFirstname] [varchar](8000) NULL,
	[OfcAdminMiddlename] [varchar](8000) NULL,
	[OfcAdminEmail] [varchar](8000) NULL,
	[OfcAdminPhone] [varchar](8000) NULL,
	[ProvSvcLocCode] [varchar](8000) NULL,
	[ProvSvcLocBeginDt] [varchar](8000) NULL,
	[ProvSvcLocEndDt] [varchar](8000) NULL,
	[ProvSvcLocName] [varchar](8000) NULL,
	[ProvSvcLocAddress1] [varchar](8000) NULL,
	[ProvSvcLocAddress2] [varchar](8000) NULL,
	[ProvSvcLocCity] [varchar](8000) NULL,
	[ProvSvcLocState] [varchar](8000) NULL,
	[ProvSvcLocZip] [varchar](8000) NULL,
	[ProvSvcLocCountryCode] [varchar](8000) NULL,
	[ProvSvcLocPhone] [varchar](8000) NULL,
	[ProvSvcLocSiteVisitIndicator] [varchar](8000) NULL,
	[CustEssentialProvIndGroup5x] [varchar](8000) NULL,
	[CustOthrProvIndGroup2x] [varchar](8000) NULL,
	[CustDHHSSPTierGroup5x] [varchar](8000) NULL,
	[ProvTaxonomyGroup20x] [varchar](8000) NULL,
	[ProvTitle] [varchar](8000) NULL,
	[PresumptiveEligInd] [varchar](8000) NULL,
	[ProvBizTypeGroup3x] [varchar](8000) NULL,
	[CLIACertNumber] [varchar](8000) NULL,
	[CLIACertType] [varchar](8000) NULL,
	[CLIABeginDt] [varchar](8000) NULL,
	[CLIAEndDt] [varchar](8000) NULL,
	[CLIACertActionReasonCode] [varchar](8000) NULL,
	[AffilOrgGroup10x] [varchar](8000) NULL,
	[FirstNameOf1099] [varchar](8000) NULL,
	[MiddleNameOf1099] [varchar](8000) NULL,
	[LastNameOf1099] [varchar](8000) NULL,
	[Address1Of1099] [varchar](8000) NULL,
	[Address2Of1099] [varchar](8000) NULL,
	[CityOf1099] [varchar](8000) NULL,
	[StateOf1099] [varchar](8000) NULL,
	[ZipOf1099] [varchar](8000) NULL,
	[AttendingOrRenderingInd] [varchar](8000) NULL,
	[OutofStateLimitEnrollInd] [varchar](8000) NULL,
	[SvcLocAfterHrsPhone] [varchar](8000) NULL,
	[SvcLocAfterHrsFax] [varchar](8000) NULL,
	[SvcCountiesGroup100x] [varchar](8000) NULL,
	[HONetworkLead] [varchar](8000) NULL,
	[HODomainHousingSvcProvInd] [varchar](8000) NULL,
	[HODomainInterPrsnSafetyInd] [varchar](8000) NULL,
	[HOFoodSvcProvInd] [varchar](8000) NULL,
	[HODomainTrnsprtSvcProvInd] [varchar](8000) NULL,
	[HOCrossDomainSvcProvInd] [varchar](8000) NULL,
	[Hours24Ind] [varchar](8000) NULL,
	[ProvLangCodeGroup33x] [varchar](8000) NULL,
	[MaleAgeGroupcode] [varchar](8000) NULL,
	[FemaleAgeGroupcode] [varchar](8000) NULL,
	[AcceptNewPatientInd] [varchar](8000) NULL,
	[AcceptSiblingPatientInd] [varchar](8000) NULL,
	[WheelchairAccessibleInd] [varchar](8000) NULL,
	[LangInterpreterInd] [varchar](8000) NULL,
	[BrailleSvcInd] [varchar](8000) NULL,
	[SignlangSvcInd] [varchar](8000) NULL,
	[BHDisruptiveSvcInd] [varchar](8000) NULL,
	[DeafHearingSvcInd] [varchar](8000) NULL,
	[PhyhandicappedSvcInd] [varchar](8000) NULL,
	[BlindSvcInd] [varchar](8000) NULL,
	[IDSvcInd] [varchar](8000) NULL,
	[SASvcInd] [varchar](8000) NULL,
	[TDDTTYEquipInd] [varchar](8000) NULL,
	[DHHSBHTCMType] [varchar](8000) NULL,
	[DHHSBHTCMEffectiveDt] [varchar](8000) NULL,
	[DHHSBHTCMEndDt] [varchar](8000) NULL,
	[HIEIndicator] [varchar](8000) NULL,
	[HIEEffectiveDt] [varchar](8000) NULL,
	[HIEEnddt] [varchar](8000) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


