﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MaintenanceWindowUtilsSchema

	/// <exclude/>
	public class MaintenanceWindowUtilsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MaintenanceWindowUtilsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MaintenanceWindowUtilsSchema(MaintenanceWindowUtilsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f67365cc-a9b0-4e5e-8589-85946c60d129");
			Name = "MaintenanceWindowUtils";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5bd8b3f2-ea32-4921-a7e4-a80db761448b");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,86,109,111,219,54,16,254,236,2,253,15,55,15,43,100,172,147,209,79,3,102,91,192,214,36,131,135,180,233,230,100,253,88,48,210,217,38,34,145,46,73,217,117,211,252,247,29,69,234,221,114,186,47,182,120,124,238,185,227,241,94,40,88,134,122,199,98,132,91,84,138,105,185,54,225,91,41,214,124,147,43,102,184,20,47,95,60,190,124,49,202,53,23,27,88,29,181,193,108,214,89,19,62,77,49,182,96,29,254,137,2,21,143,123,152,11,102,88,79,120,205,197,231,90,216,116,32,203,164,56,189,163,112,72,30,94,252,65,91,180,249,163,194,13,57,3,111,83,166,245,111,240,142,113,97,80,48,17,227,71,46,18,121,184,51,60,213,5,114,58,157,194,92,231,89,198,212,49,242,235,119,104,182,50,209,176,150,10,14,82,61,88,67,7,110,182,144,213,60,36,176,68,58,44,57,166,13,146,93,126,159,242,24,98,107,125,208,248,232,177,112,224,89,95,151,180,84,123,150,58,244,78,241,61,51,56,196,93,131,71,37,127,109,128,110,199,168,60,54,82,145,157,15,133,143,30,226,29,30,164,11,150,246,246,254,65,150,160,2,85,252,77,224,177,80,29,145,10,36,236,248,62,207,238,105,115,225,183,41,13,12,101,69,158,137,127,89,154,227,156,80,81,48,190,40,113,227,201,204,105,19,47,222,242,12,65,27,166,76,241,53,68,81,66,137,103,85,130,251,60,40,146,239,101,185,116,208,6,199,241,102,253,17,241,129,148,235,19,253,2,111,252,254,170,225,98,229,110,104,127,110,214,164,235,81,151,149,3,222,149,46,226,169,188,23,218,119,87,211,185,168,15,74,238,80,25,142,3,215,100,35,94,251,250,8,27,52,51,120,106,34,172,197,213,142,9,168,93,62,11,43,125,174,65,39,61,244,242,174,184,244,251,138,99,154,88,159,93,142,182,19,214,222,134,20,233,17,238,52,42,74,69,225,250,5,124,202,91,235,217,73,157,107,246,245,56,191,230,218,204,7,83,52,138,224,19,247,223,122,118,222,209,225,74,104,181,131,165,224,134,179,148,127,69,13,12,4,30,40,242,116,239,182,250,229,26,204,22,9,138,84,138,10,215,139,241,233,50,31,79,35,87,170,97,171,65,56,59,59,166,88,6,130,250,239,98,220,142,194,56,178,81,130,184,18,144,122,129,46,148,135,170,181,176,24,116,226,219,38,46,171,182,19,117,74,214,19,215,48,170,3,74,0,123,254,239,186,135,224,90,178,164,92,106,87,92,207,100,142,239,184,3,169,243,140,65,104,217,11,202,35,238,153,130,158,255,231,153,2,223,9,172,170,70,59,209,254,206,81,29,73,57,88,21,203,137,37,113,159,65,39,132,19,87,253,118,20,234,162,209,185,242,12,125,23,97,26,234,230,247,26,26,29,140,22,85,35,242,28,87,74,102,65,63,163,170,253,37,25,85,127,73,46,26,134,198,147,240,166,181,38,222,101,66,210,165,190,252,156,83,11,63,193,71,144,10,111,177,238,244,141,147,135,151,95,48,206,13,186,206,31,184,142,10,139,168,236,253,205,24,251,16,15,207,16,63,55,102,213,216,112,87,19,254,158,36,65,185,242,187,79,254,95,161,201,149,128,102,93,255,143,92,26,170,235,82,112,129,68,155,113,65,229,125,216,146,22,29,205,22,245,134,239,81,208,0,160,204,227,218,150,60,79,16,152,56,218,162,31,120,1,244,159,0,253,10,183,132,227,232,150,12,216,175,215,96,36,196,91,140,31,90,165,93,104,185,83,235,90,16,71,212,173,112,62,141,35,224,235,158,143,206,65,45,169,127,247,221,155,129,180,7,59,112,77,38,137,104,77,81,44,152,26,110,55,237,249,222,178,231,202,80,210,192,189,148,41,44,181,29,154,75,209,187,218,160,154,186,214,147,178,240,42,97,110,98,251,93,76,83,67,99,80,222,9,114,91,105,150,218,237,178,216,170,33,100,220,212,244,90,221,169,105,83,45,105,12,104,155,50,147,18,91,101,177,195,14,230,96,51,89,235,230,22,22,47,131,240,138,43,109,110,212,5,174,89,158,154,224,208,214,172,147,190,136,9,215,116,147,133,217,26,1,109,149,176,241,158,88,212,190,207,90,44,239,241,139,233,210,4,131,60,63,195,155,9,252,4,191,158,34,44,154,150,237,42,125,71,170,102,211,128,82,245,244,129,190,17,181,93,92,22,9,86,251,231,54,71,206,214,124,225,238,237,213,43,247,63,47,158,61,118,121,34,66,223,190,121,93,11,153,251,71,148,197,246,184,206,41,119,236,116,185,78,196,212,159,167,236,38,157,19,157,109,57,240,3,181,181,60,77,207,116,30,39,109,11,73,246,31,97,188,179,123,88,13,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f67365cc-a9b0-4e5e-8589-85946c60d129"));
		}

		#endregion

	}

	#endregion

}
