﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: GrantRightsToExternalColumnsExecutorSchema

	/// <exclude/>
	public class GrantRightsToExternalColumnsExecutorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public GrantRightsToExternalColumnsExecutorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public GrantRightsToExternalColumnsExecutorSchema(GrantRightsToExternalColumnsExecutorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a9bcf047-e11f-4720-a629-4cc2e09bf794");
			Name = "GrantRightsToExternalColumnsExecutor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e4ab0bc5-d9f5-40fb-aa3b-d9475e1e35c3");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,189,88,109,111,219,54,16,254,172,2,253,15,156,7,20,50,96,9,242,187,221,44,45,36,91,14,92,180,105,16,187,235,135,97,8,20,137,73,184,201,146,75,82,73,141,160,255,125,39,82,239,47,174,91,20,11,2,219,36,143,119,15,121,119,15,143,68,129,179,195,108,239,184,24,109,49,165,14,11,239,184,190,8,131,59,114,31,81,135,147,48,120,249,226,249,229,11,37,98,36,184,71,155,3,227,120,119,86,105,131,188,239,99,55,22,102,250,5,14,48,37,110,77,102,233,112,167,214,249,158,4,95,242,206,34,128,221,46,12,154,71,40,110,235,47,227,110,149,90,90,173,67,118,192,9,39,152,129,0,136,236,163,91,159,184,200,245,29,198,208,5,117,2,126,77,238,31,56,219,134,246,87,142,105,224,248,176,240,104,23,48,251,43,118,35,30,82,244,26,173,215,1,227,142,239,111,92,74,246,60,29,0,101,207,66,165,242,59,197,247,0,14,173,8,246,61,246,26,93,81,242,232,112,44,7,247,178,129,62,49,76,97,45,129,220,83,116,19,149,218,103,69,81,129,248,176,113,31,240,206,249,224,4,206,61,166,232,6,215,59,75,147,40,118,188,48,240,15,232,34,34,30,186,217,135,20,32,95,135,62,22,237,115,20,224,39,49,164,118,166,3,195,154,78,251,11,205,158,154,83,109,180,26,246,181,249,98,101,105,227,193,98,57,232,47,134,211,225,124,213,233,30,83,14,123,97,239,246,126,120,192,172,209,130,57,152,155,67,203,28,107,35,203,88,106,75,187,15,22,204,113,95,51,140,177,49,158,44,12,248,155,85,44,188,39,140,255,193,56,5,7,190,65,55,76,132,82,226,137,68,117,73,226,25,117,108,107,53,177,172,249,80,155,153,230,68,27,153,6,24,49,192,220,98,98,155,147,169,185,90,217,131,126,167,215,25,26,253,241,120,60,183,181,133,181,0,49,99,98,106,179,153,185,210,140,233,106,58,31,26,150,61,27,14,58,189,24,138,210,153,207,7,51,123,105,47,180,209,96,58,128,143,177,169,205,135,150,165,141,102,211,209,112,101,219,176,156,17,168,180,103,70,127,110,192,242,140,161,5,98,198,124,12,150,87,83,205,236,207,135,230,124,98,152,75,219,238,124,59,75,130,3,7,158,140,143,114,176,124,192,252,33,108,141,22,177,88,85,174,22,73,167,127,90,123,61,148,244,200,157,129,158,238,27,116,129,121,178,81,106,23,61,139,133,60,58,20,185,245,205,107,215,231,230,250,84,233,23,161,131,225,152,2,208,185,232,80,98,61,27,209,163,86,162,183,43,5,20,93,2,81,59,87,34,250,164,29,211,117,49,99,49,128,78,15,117,50,219,157,174,110,50,181,216,110,86,34,91,101,37,217,242,19,37,133,182,84,162,175,104,184,107,133,145,89,90,195,2,232,187,144,180,27,235,234,31,143,34,41,90,136,251,10,235,0,245,204,254,18,57,254,177,237,40,200,35,135,37,219,43,29,32,201,76,93,90,25,19,121,183,217,207,243,42,129,0,205,177,136,226,165,149,119,169,221,52,30,82,93,235,152,176,175,33,151,129,80,188,252,231,121,226,104,93,170,199,178,91,205,205,229,138,148,167,7,226,99,164,230,179,245,248,171,96,74,81,146,200,211,77,207,83,213,180,83,41,24,212,179,144,253,211,241,35,156,38,117,41,24,122,63,52,177,22,0,138,210,77,226,88,81,190,201,239,228,75,196,181,180,67,188,56,61,82,184,73,104,203,38,58,127,147,12,232,25,168,174,190,4,175,145,0,132,186,250,54,140,93,152,38,139,114,7,39,141,227,62,32,181,160,126,237,33,18,20,108,229,91,84,146,206,114,47,150,46,51,95,219,166,178,60,129,243,204,109,89,47,197,60,162,65,186,74,41,35,134,196,71,145,115,30,67,160,241,13,230,197,227,71,2,17,71,228,123,252,136,125,85,112,189,227,237,72,240,41,32,60,70,32,122,10,136,68,59,131,149,248,241,152,78,68,179,159,61,216,3,254,22,237,67,70,196,41,9,228,21,249,126,186,13,210,67,112,24,185,33,245,214,222,230,103,217,169,198,19,80,185,180,0,204,4,63,63,96,138,65,50,186,253,7,180,54,176,86,154,236,114,178,126,229,80,40,194,160,162,200,157,213,77,117,153,129,151,105,170,71,110,187,166,130,175,75,154,14,204,204,29,114,130,158,130,251,32,111,43,180,35,220,151,110,49,56,32,110,235,112,218,243,195,255,79,75,101,79,159,66,79,228,238,56,55,21,22,86,69,186,180,182,135,61,134,142,71,76,97,151,160,45,72,102,27,138,154,38,87,250,151,241,119,115,170,201,207,24,193,111,169,25,93,120,128,169,249,38,230,96,100,98,22,18,82,169,238,250,37,126,18,182,19,115,80,133,2,178,36,181,100,213,154,116,21,82,64,246,180,166,192,58,224,225,41,241,174,0,29,114,145,41,61,84,139,159,20,103,183,44,188,0,82,227,216,251,24,52,205,1,23,227,45,217,97,253,50,124,106,158,103,29,154,173,85,253,180,136,40,133,98,56,174,167,245,26,134,15,161,71,238,200,79,128,72,39,254,18,20,53,150,104,80,88,163,133,242,220,156,23,26,230,214,136,32,157,91,102,130,134,153,165,212,47,205,205,249,184,209,229,217,104,122,206,108,32,241,176,119,69,67,23,123,144,225,80,66,240,107,17,23,87,9,121,231,67,69,134,46,207,170,110,43,84,68,156,237,111,54,85,93,121,88,126,38,252,33,135,213,217,58,183,62,190,132,150,168,45,79,8,235,202,124,40,190,119,14,61,72,209,84,79,145,68,143,201,11,126,128,9,89,62,180,76,186,160,97,180,223,3,213,229,102,152,192,91,9,147,30,106,63,20,170,56,210,141,233,229,135,229,219,183,200,144,116,94,222,100,233,175,118,255,128,155,221,127,225,62,25,227,106,228,69,59,184,39,1,214,229,253,190,32,252,235,15,132,124,166,190,225,14,229,91,184,160,51,39,145,74,72,183,206,127,233,193,80,60,18,18,225,35,171,110,159,84,64,17,63,90,144,38,24,105,9,85,43,160,10,111,10,217,125,76,70,37,218,55,94,35,146,193,243,198,43,126,92,241,74,1,235,16,111,249,145,187,72,149,242,207,178,227,232,184,221,114,141,213,112,44,253,192,93,52,191,116,22,111,165,82,89,67,209,27,87,188,110,165,212,21,231,167,84,13,21,204,37,64,251,72,197,201,169,214,234,113,244,234,21,58,42,154,67,203,75,128,239,21,184,105,165,80,121,65,233,161,116,64,28,205,144,138,12,215,17,29,147,202,193,228,82,199,144,232,11,39,176,61,194,179,98,227,100,228,13,207,51,189,147,208,159,4,254,103,176,127,171,229,204,247,159,69,196,67,93,146,96,242,209,78,228,87,154,182,149,247,180,74,240,39,238,174,228,4,196,101,195,179,155,210,148,120,53,81,189,225,85,46,169,152,139,25,127,214,190,70,232,133,255,255,0,84,27,97,14,157,21,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a9bcf047-e11f-4720-a629-4cc2e09bf794"));
		}

		#endregion

	}

	#endregion

}

