﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CaseEntityFileCopierSchema

	/// <exclude/>
	public class CaseEntityFileCopierSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CaseEntityFileCopierSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CaseEntityFileCopierSchema(CaseEntityFileCopierSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("828798ff-f221-49bb-b0cc-0e97641c9dca");
			Name = "CaseEntityFileCopier";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c3c90037-274c-4793-841e-197eb228d3cd");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,221,26,219,110,219,54,244,217,5,246,15,132,55,20,50,96,40,123,206,197,64,155,94,96,160,233,178,38,217,30,134,62,48,18,157,112,147,69,151,164,82,120,65,254,125,231,240,34,145,148,100,39,77,247,176,189,36,17,117,238,119,30,165,166,107,166,54,180,96,228,146,73,73,149,88,233,252,84,212,43,126,211,72,170,185,168,243,115,90,252,69,111,152,202,79,169,98,63,188,184,255,225,197,164,81,188,190,33,23,91,165,217,250,40,121,206,151,191,244,142,78,69,85,177,2,169,169,252,61,171,153,228,69,15,230,3,175,191,116,135,99,194,188,227,21,187,218,84,130,150,195,176,146,141,157,231,111,107,205,53,103,106,20,224,29,45,180,144,22,2,96,126,148,236,6,88,146,211,138,42,117,72,80,123,67,98,139,50,156,138,13,103,210,192,29,28,28,144,99,213,172,215,84,110,23,238,25,94,111,129,3,66,190,97,154,242,234,74,243,10,80,201,74,72,67,9,223,228,30,249,32,192,254,227,13,91,209,166,210,175,121,93,2,133,76,111,55,76,172,178,101,202,122,54,39,31,193,117,228,132,76,145,222,116,246,25,144,55,205,117,197,11,82,160,196,131,2,147,67,210,163,4,120,247,70,145,33,141,17,204,34,88,171,47,235,149,176,192,169,218,230,224,19,219,72,166,88,173,21,89,1,38,225,0,222,211,185,175,244,100,35,133,134,0,97,101,32,251,16,107,144,127,88,162,137,215,161,83,2,130,77,83,144,228,144,156,75,126,71,53,115,0,27,251,68,10,4,32,74,75,19,10,84,222,48,141,180,47,138,91,182,166,161,109,241,116,122,180,15,215,226,181,254,56,242,226,176,186,180,18,37,242,157,27,95,29,90,57,101,131,161,167,28,72,207,180,230,100,89,67,248,210,138,255,205,20,169,217,87,176,45,234,7,137,43,86,0,205,64,40,201,86,39,211,49,211,77,15,22,57,233,200,71,230,247,129,51,134,155,57,77,153,57,239,44,52,39,239,27,94,26,87,47,203,185,183,7,62,226,219,153,33,61,153,28,146,107,160,155,245,145,61,94,139,64,238,45,202,82,125,100,172,188,20,31,133,230,171,45,216,116,69,43,197,172,11,30,254,95,70,154,147,107,33,42,194,35,141,191,163,229,98,194,177,9,199,99,83,138,13,147,88,44,15,93,156,238,49,122,201,11,72,11,69,248,138,112,13,60,193,246,144,203,90,144,218,202,81,113,168,241,80,247,21,250,33,170,5,59,12,109,12,147,40,228,212,132,124,59,34,10,126,60,78,159,51,166,111,69,249,56,101,206,232,95,152,223,27,168,213,82,172,137,18,141,132,240,9,98,103,217,245,32,31,50,99,138,152,163,13,149,116,77,106,240,210,201,212,82,155,46,46,44,85,83,35,27,67,202,148,74,185,182,93,238,248,192,32,141,16,129,191,33,34,160,167,54,235,250,55,90,53,64,239,220,28,129,216,120,70,238,240,144,52,53,255,210,48,94,98,244,172,160,206,239,161,10,37,13,92,164,167,11,84,143,184,167,80,239,88,109,236,203,6,30,212,239,19,150,76,55,178,86,150,86,175,9,60,54,19,143,15,60,157,48,44,32,161,245,142,52,52,189,247,29,184,46,150,55,75,220,230,28,59,39,46,213,76,142,246,44,59,39,23,90,50,176,145,179,71,155,103,238,57,63,23,138,163,203,32,211,126,182,193,56,185,163,210,56,214,10,102,120,157,56,38,88,145,70,203,199,80,11,178,181,35,255,200,190,226,239,12,154,190,21,219,204,65,81,226,79,38,231,129,240,174,125,133,157,105,62,4,103,148,4,192,190,226,30,250,82,104,90,33,183,15,172,190,209,183,0,235,36,72,94,180,8,46,46,0,208,217,200,189,120,112,230,177,46,77,44,52,158,199,237,105,154,220,35,195,10,76,32,232,18,33,183,22,108,108,178,232,224,220,76,17,34,14,76,19,49,23,235,54,55,0,142,51,241,96,142,69,135,53,233,56,196,3,139,27,4,146,74,53,80,170,236,152,9,177,105,202,110,208,229,112,96,28,74,48,207,188,173,87,67,5,171,95,22,26,197,36,72,86,219,241,125,186,184,130,103,244,172,59,136,115,63,109,145,158,103,118,21,81,33,49,209,25,113,125,46,61,118,161,253,208,90,42,173,239,3,5,222,123,194,67,116,174,17,119,48,238,67,57,36,119,2,82,29,196,171,94,105,232,197,215,13,88,48,123,195,13,79,48,196,177,109,208,115,34,174,255,4,196,5,161,45,212,156,164,69,100,21,61,182,57,224,90,250,5,211,175,65,175,142,77,151,173,168,111,158,200,16,50,74,8,15,18,115,9,53,129,166,155,13,188,39,47,95,146,44,166,131,157,121,180,110,22,238,5,62,204,130,186,210,137,245,199,52,238,198,211,207,152,229,1,90,190,28,152,54,140,3,159,236,199,199,132,255,5,189,99,238,162,225,251,21,175,97,232,40,169,166,198,192,79,136,243,216,80,174,11,238,107,205,125,50,198,15,167,141,210,98,109,171,169,154,46,150,10,71,21,82,152,83,215,163,213,112,226,152,208,68,181,150,160,199,155,235,94,211,74,195,162,11,180,136,39,184,5,42,73,208,28,144,100,54,24,83,17,158,15,169,113,79,237,29,181,118,84,177,225,121,235,41,53,172,171,209,79,154,186,158,84,195,146,18,214,177,124,86,17,251,174,35,170,117,162,141,252,199,91,225,155,34,252,123,5,120,52,21,2,60,222,47,12,59,162,154,162,96,74,173,154,106,100,222,107,235,182,9,118,171,1,202,254,173,201,209,102,5,14,106,141,239,208,39,36,28,206,70,26,151,207,15,143,149,7,210,60,62,187,220,4,132,25,250,140,185,39,186,163,197,93,111,112,53,147,6,253,190,69,76,18,237,201,227,61,49,87,176,135,29,12,77,124,201,110,204,10,242,121,215,118,47,202,241,125,66,38,147,92,242,24,11,57,58,64,142,86,172,65,181,158,176,97,72,55,109,237,118,161,175,210,179,106,214,96,170,7,118,92,124,15,87,132,12,131,26,153,234,184,187,74,206,83,23,197,146,250,212,76,104,156,36,84,108,214,36,148,78,18,90,71,65,14,253,87,28,249,205,118,125,158,225,194,202,23,244,187,102,160,246,237,201,165,177,57,124,100,89,108,138,189,29,224,2,139,191,13,214,93,96,105,114,189,37,107,170,52,152,77,217,29,43,26,118,164,126,245,204,111,49,187,27,245,116,113,214,167,213,75,166,104,127,49,46,90,210,177,186,186,20,194,145,247,225,173,222,111,9,83,185,188,7,253,246,160,93,39,199,46,205,67,202,103,180,166,55,208,133,128,193,210,5,239,235,45,18,203,126,154,222,167,12,30,204,26,219,245,160,224,18,110,33,246,102,75,232,44,213,55,73,247,133,7,61,134,203,158,194,126,2,121,172,159,236,86,225,172,231,45,183,41,27,8,128,157,21,48,36,247,137,21,66,150,203,50,37,38,205,249,238,61,89,127,249,38,57,42,209,173,89,166,11,243,69,139,162,219,71,34,229,215,134,153,18,74,28,178,223,211,237,143,189,125,150,30,13,192,59,46,117,67,43,146,226,248,96,84,151,2,247,100,62,26,135,173,239,54,215,67,182,116,87,93,209,180,95,65,122,134,241,17,29,229,130,165,245,46,12,240,36,61,6,37,113,97,235,147,67,189,85,95,92,221,234,217,57,75,89,56,92,143,151,67,66,189,42,215,188,254,196,111,110,181,138,63,46,244,148,112,109,197,32,190,42,75,251,34,107,143,62,9,225,214,107,152,132,231,41,118,54,155,229,248,59,145,0,100,3,237,20,18,108,73,89,123,230,246,54,100,1,126,231,250,246,28,99,131,33,116,102,15,79,197,26,226,133,43,81,95,194,37,41,127,251,5,188,60,31,245,223,144,235,102,253,26,96,164,2,5,210,104,25,28,127,31,221,2,226,73,10,34,155,215,183,76,114,93,138,226,32,108,119,230,210,139,209,248,170,170,190,61,32,237,43,109,54,158,137,194,255,78,32,90,128,15,92,233,14,183,77,171,39,248,99,78,48,139,144,98,63,133,44,183,128,100,39,96,126,133,168,67,250,206,3,209,92,88,93,48,244,168,251,144,68,78,22,238,35,21,250,28,195,168,12,54,191,199,104,199,69,214,151,101,150,95,10,36,153,205,102,123,187,197,169,249,126,98,10,152,249,138,34,106,230,88,226,71,33,90,11,13,145,240,180,214,208,105,126,101,74,185,245,90,90,188,113,120,83,193,199,21,167,231,206,146,62,100,195,233,194,238,206,159,213,43,58,193,145,108,9,55,101,19,45,32,162,53,205,8,209,64,7,199,125,64,139,52,119,178,32,51,34,83,237,72,140,57,89,162,64,214,227,36,149,214,167,13,52,115,70,139,91,146,249,234,187,196,125,193,40,184,251,223,10,3,189,102,107,24,36,221,39,20,91,175,207,130,163,44,88,51,34,248,245,87,168,14,237,93,252,53,199,117,236,239,230,40,11,41,181,139,207,86,32,243,141,37,185,90,228,31,252,205,124,208,40,254,11,170,227,217,210,76,136,4,23,252,241,127,135,176,123,210,124,228,195,147,151,112,44,89,35,213,130,13,156,255,57,92,111,237,105,124,248,240,15,108,130,124,108,205,35,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("828798ff-f221-49bb-b0cc-0e97641c9dca"));
		}

		#endregion

	}

	#endregion

}
