﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IMLServiceProxySchema

	/// <exclude/>
	public class IMLServiceProxySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IMLServiceProxySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IMLServiceProxySchema(IMLServiceProxySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("3985eb50-d2b3-4d48-8a6a-1934838eb692");
			Name = "IMLServiceProxy";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b54cb82a-9c72-40e4-855f-14a0ef44684e");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,221,89,77,111,27,55,16,61,59,64,254,3,161,30,234,0,130,116,79,20,1,169,221,24,2,164,212,176,236,244,76,237,206,74,44,246,67,37,185,118,141,32,255,189,51,67,114,191,36,173,54,110,17,180,185,196,90,238,240,113,248,230,205,12,185,201,101,6,102,47,35,16,247,160,181,52,69,98,39,87,69,158,168,109,169,165,85,69,62,89,45,95,191,250,242,250,213,69,105,84,190,21,235,103,99,33,123,215,121,198,41,105,10,17,217,155,201,13,228,160,85,84,219,212,200,171,229,100,145,91,208,9,46,104,206,26,76,238,208,53,68,100,83,52,254,73,195,22,87,16,149,197,91,177,88,45,215,160,31,85,4,183,186,248,235,153,205,166,211,169,152,153,50,203,164,126,158,251,231,106,138,72,10,45,34,153,166,180,110,38,163,157,202,65,164,32,117,78,3,198,97,77,2,202,180,1,179,47,55,169,138,196,94,106,171,100,42,84,133,120,224,195,197,23,246,163,242,119,5,118,87,196,230,173,184,101,8,247,178,235,37,15,172,45,162,27,145,195,147,176,90,170,28,29,50,134,130,80,205,152,118,167,204,208,33,153,137,28,227,248,126,148,129,149,215,210,202,209,28,215,148,34,198,159,162,72,132,221,129,200,138,24,210,159,13,250,189,47,173,144,121,44,138,210,226,207,201,108,202,8,39,0,105,214,58,218,65,38,23,49,162,46,29,142,48,60,36,84,12,185,85,137,2,125,8,163,193,150,58,55,243,123,92,188,182,11,238,24,218,41,196,213,6,103,211,96,79,0,55,165,138,29,25,247,68,195,218,25,93,26,171,57,108,126,151,99,193,118,45,31,223,188,235,161,247,97,159,22,50,54,142,23,91,56,71,234,144,15,97,56,102,118,175,61,64,201,128,253,20,250,29,18,125,199,169,224,72,59,245,5,46,106,184,199,2,119,232,252,166,69,47,87,75,247,128,246,236,68,92,243,80,45,212,203,193,47,168,201,220,180,22,30,186,119,219,136,69,216,78,75,166,189,122,232,232,20,51,226,19,254,30,205,233,223,64,197,19,108,132,123,119,72,2,59,126,239,93,190,228,29,183,29,26,139,90,31,30,189,151,137,27,176,148,14,88,16,50,174,116,66,110,48,37,142,135,228,187,48,20,50,160,147,11,96,3,34,250,26,74,34,121,31,200,104,188,62,198,75,47,9,87,88,10,141,136,82,137,198,137,138,28,17,223,152,19,156,128,139,28,83,58,143,224,33,236,219,21,10,229,135,113,227,253,146,112,137,181,224,234,196,249,137,28,165,152,171,92,175,219,238,49,242,105,250,150,202,88,18,212,204,0,136,72,67,242,126,116,213,2,64,14,203,212,142,166,243,78,213,105,91,253,198,229,81,248,193,231,203,186,214,52,182,58,22,215,138,219,30,146,51,115,242,27,139,98,243,7,246,194,57,111,163,151,252,117,84,104,48,2,27,173,235,75,10,91,169,120,82,118,199,34,220,170,71,200,29,23,174,77,114,185,218,67,68,242,241,174,124,83,136,176,126,211,159,49,2,73,43,204,174,40,211,88,236,177,139,97,6,96,69,47,200,251,33,65,162,232,54,91,11,187,221,196,220,0,195,193,153,144,239,209,2,217,195,227,6,18,183,41,249,244,48,170,76,23,121,76,145,0,51,22,42,9,146,12,43,184,176,161,186,98,245,168,226,18,251,113,2,18,135,48,224,77,52,170,209,197,35,104,20,185,240,171,181,179,249,132,132,110,157,45,245,39,218,7,71,168,35,150,181,227,203,171,132,35,137,197,153,9,118,231,39,23,160,179,2,25,139,77,81,84,222,181,184,24,170,29,151,36,169,151,61,69,195,252,231,85,68,73,234,148,20,252,14,138,114,254,255,240,114,50,29,61,17,33,179,150,168,230,125,170,90,176,253,105,109,57,113,145,209,152,208,47,94,38,178,91,23,86,148,25,108,181,239,96,24,162,188,204,232,132,47,30,101,90,194,119,21,223,249,46,51,236,0,50,68,130,180,175,122,223,167,251,77,29,221,22,47,199,226,27,23,120,3,128,185,184,115,176,167,122,202,240,224,14,139,222,221,135,155,127,45,249,15,73,239,103,250,207,18,12,109,195,205,12,79,67,216,148,185,121,194,83,50,139,41,81,233,65,198,220,201,109,243,52,132,143,31,120,198,241,132,241,103,195,224,192,80,217,71,69,150,65,30,187,131,7,41,162,102,175,196,34,98,94,82,58,7,50,199,248,163,249,3,253,161,202,179,5,219,113,168,127,62,217,234,216,92,21,101,142,58,255,84,102,27,119,231,240,5,182,168,193,120,99,128,151,97,222,83,63,42,70,2,47,190,11,194,192,227,90,128,114,163,131,103,18,13,142,12,114,200,189,24,15,152,252,33,213,32,227,103,190,205,75,18,137,247,227,35,191,165,27,173,144,206,196,221,207,217,38,164,179,46,178,102,213,62,203,189,199,126,216,35,217,33,220,14,235,44,239,50,141,202,20,103,61,184,16,222,213,35,30,166,29,71,227,179,179,113,98,173,29,152,206,155,171,221,181,38,86,250,175,134,143,139,159,235,9,21,155,185,91,127,76,244,136,166,64,92,151,104,216,53,162,37,222,99,101,75,83,103,210,118,224,99,59,166,162,19,99,156,217,107,63,249,125,135,132,54,58,84,95,152,17,204,234,18,252,110,232,246,107,192,126,166,82,235,118,117,232,43,67,118,195,129,22,137,76,77,255,221,208,87,161,16,152,213,82,172,255,233,157,104,245,178,78,213,188,42,123,175,26,238,248,187,46,219,14,58,29,97,12,110,105,212,84,104,84,216,216,240,140,172,173,202,0,19,108,13,17,150,114,247,155,235,70,95,74,217,231,61,52,49,238,241,100,195,95,145,130,251,58,8,152,44,113,126,53,225,100,99,32,119,195,172,78,67,32,244,16,185,25,61,204,79,53,216,131,15,5,99,81,195,187,59,104,151,47,167,40,74,155,154,8,148,82,251,219,223,228,26,18,137,119,203,26,204,51,245,70,60,237,0,79,126,236,226,91,250,192,119,73,250,187,184,248,31,40,176,62,43,253,138,246,86,129,63,224,85,103,190,234,206,254,125,148,28,119,57,14,130,246,228,55,66,119,74,216,63,180,184,191,225,106,112,36,17,88,230,190,184,250,175,49,199,249,14,149,86,188,56,39,120,169,163,121,193,95,207,177,103,184,15,232,252,252,213,253,23,64,107,240,235,223,239,212,87,208,190,24,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3985eb50-d2b3-4d48-8a6a-1934838eb692"));
		}

		#endregion

	}

	#endregion

}

