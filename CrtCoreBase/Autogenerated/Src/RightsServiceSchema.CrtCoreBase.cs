﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: RightsServiceSchema

	/// <exclude/>
	public class RightsServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public RightsServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public RightsServiceSchema(RightsServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("10bb4f79-5b92-47ce-b685-8e404e4984b9");
			Name = "RightsService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5af8fc1f-99e6-4265-b65c-5e9401c4c7dd");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,237,93,91,115,219,184,21,126,246,206,236,127,192,42,51,30,106,170,165,119,251,232,196,74,125,219,172,183,73,236,177,156,230,193,117,103,104,18,182,217,72,164,150,4,109,171,25,255,247,30,220,1,18,188,72,150,92,166,147,60,56,18,8,28,124,56,119,128,0,148,4,51,156,207,131,16,163,11,156,101,65,158,222,16,255,48,77,110,226,219,34,11,72,156,38,254,121,124,123,71,242,9,206,238,227,16,255,248,195,215,31,127,216,42,242,56,185,69,147,69,78,240,236,117,233,59,180,158,78,113,72,155,230,254,59,156,224,44,14,43,117,222,199,201,159,149,194,243,34,33,241,12,251,208,85,28,76,227,255,176,238,43,181,38,56,44,178,152,44,28,15,24,194,15,105,132,167,141,15,253,125,64,119,95,71,221,168,247,25,95,87,42,92,224,71,226,159,227,219,98,26,100,199,143,243,12,231,57,29,105,165,30,180,5,98,236,225,132,4,4,235,10,38,159,103,51,19,131,249,36,171,105,145,97,255,232,160,246,209,111,65,72,210,44,198,121,109,13,115,128,32,103,146,65,11,87,101,138,95,225,131,231,175,50,124,11,99,65,135,211,32,207,119,81,73,41,160,194,206,206,14,122,147,23,179,89,144,45,198,226,251,62,122,192,215,40,231,181,80,145,227,8,145,20,205,130,36,184,197,40,99,36,124,217,116,199,104,123,41,8,75,128,87,180,108,63,159,127,196,4,48,205,65,116,215,241,20,116,224,28,255,89,196,25,158,225,132,228,158,249,133,14,15,237,161,150,38,180,150,47,10,162,33,237,100,94,92,79,227,16,133,116,144,246,24,209,46,58,8,114,44,190,141,208,201,57,14,162,211,100,186,48,133,12,20,190,50,102,40,118,125,192,228,46,141,128,97,103,25,85,57,206,170,173,57,255,194,40,158,131,249,129,2,97,116,252,8,154,77,176,212,239,211,57,230,6,232,237,51,99,122,195,225,252,142,167,240,96,12,76,45,85,227,181,134,136,218,231,214,150,89,89,112,90,124,217,67,239,48,177,134,198,31,120,195,215,172,229,125,0,13,36,166,61,148,224,7,11,166,172,70,178,133,232,106,171,6,138,103,118,43,90,61,161,48,32,225,29,242,142,31,67,60,167,181,16,150,144,183,100,175,160,163,4,124,193,5,248,2,85,205,195,146,2,251,155,97,82,100,137,194,201,30,61,217,188,205,73,70,53,26,6,123,24,36,71,120,138,9,246,68,89,30,222,225,89,240,17,60,31,200,241,56,41,102,128,251,122,138,223,188,43,226,104,140,128,0,213,67,112,99,197,44,249,71,48,45,112,254,124,174,198,55,200,115,16,230,3,135,1,83,143,233,197,17,218,27,243,162,45,147,186,111,14,98,194,192,43,94,179,62,61,61,162,33,218,222,238,70,226,28,135,105,22,149,219,143,80,28,13,135,2,215,254,116,234,133,174,86,128,19,57,31,12,13,105,50,17,113,150,251,199,179,57,119,217,82,130,174,97,188,199,247,120,154,115,198,138,207,123,232,19,184,15,240,3,9,15,41,16,57,66,61,34,78,4,138,56,231,173,97,144,172,144,58,115,157,166,83,116,23,228,178,34,80,245,204,78,182,81,61,26,95,113,109,136,246,246,248,208,186,212,126,109,234,169,209,55,167,240,22,13,116,171,207,65,150,0,143,62,128,35,1,191,56,224,53,118,37,231,126,75,179,89,64,60,106,135,239,211,144,197,69,208,213,9,123,232,13,108,239,62,24,161,129,102,144,50,30,202,52,156,132,248,99,74,126,75,139,36,26,12,135,46,139,57,138,25,139,65,69,223,240,190,71,136,114,110,76,85,123,146,207,97,104,212,231,113,245,205,171,182,180,30,215,195,233,85,229,126,12,185,1,89,112,206,127,96,1,132,105,192,73,146,147,0,134,118,176,160,16,76,59,224,36,223,199,57,17,163,25,163,96,58,77,31,176,28,1,244,81,182,16,24,37,239,97,63,12,65,26,106,168,101,170,82,183,89,185,47,170,217,182,28,82,19,161,66,251,59,94,48,91,63,11,226,204,230,171,23,250,92,85,109,92,52,253,34,65,12,253,242,231,67,101,142,23,169,22,145,247,72,59,120,244,129,252,8,137,207,172,31,167,104,129,73,4,226,218,125,10,46,230,44,200,114,204,251,162,228,165,36,47,175,80,168,11,71,40,45,136,75,35,76,134,142,209,109,150,22,115,133,156,55,178,88,206,89,36,158,75,13,177,91,137,32,211,214,151,84,18,161,119,16,209,9,6,25,236,161,191,13,254,121,233,93,254,107,247,234,47,195,93,248,255,10,254,191,26,136,186,102,239,162,31,147,168,164,121,3,182,19,208,176,36,136,115,70,160,56,49,89,162,60,219,7,22,194,102,236,239,30,130,92,16,63,250,172,204,227,181,71,18,156,160,206,156,63,171,238,79,10,166,88,138,148,28,205,23,188,0,82,188,206,59,202,157,252,242,215,43,46,79,65,131,17,249,201,230,156,210,20,80,2,15,72,104,231,91,230,241,37,60,189,106,96,128,244,202,206,118,254,126,20,121,22,182,191,94,153,186,70,195,58,248,62,172,7,101,178,157,181,230,140,81,213,117,28,88,194,5,217,254,231,0,50,185,41,52,137,184,193,122,75,170,170,228,20,117,57,28,92,78,137,115,231,84,175,145,220,110,203,90,163,137,48,254,80,189,113,247,102,118,199,189,97,121,80,98,52,6,53,110,225,102,129,197,122,7,8,173,183,249,112,75,202,164,50,72,38,23,59,198,12,46,191,254,242,180,251,245,215,167,171,129,221,163,1,129,126,30,170,47,182,22,84,19,180,74,175,203,198,157,26,254,56,18,57,203,237,56,204,246,57,146,166,182,103,144,4,187,131,169,42,26,163,95,148,96,87,15,122,6,48,70,252,8,198,17,39,33,104,54,52,53,59,189,72,233,16,189,161,47,107,88,20,98,25,173,246,163,89,156,64,141,44,224,36,74,113,244,232,64,78,48,142,147,219,56,193,44,136,230,102,116,181,8,28,44,106,131,32,247,72,53,253,110,111,151,59,62,44,178,12,38,93,180,212,215,197,23,139,57,204,50,56,74,250,217,159,76,206,180,23,19,90,228,206,63,42,120,158,76,110,168,236,172,194,16,71,90,76,233,182,229,213,198,160,235,199,92,219,175,30,211,6,146,28,78,52,161,90,66,179,12,160,107,103,38,254,231,59,156,97,158,146,216,106,92,74,52,172,228,197,147,161,68,166,41,161,111,76,93,104,145,168,48,84,48,148,51,178,3,41,111,110,21,41,26,67,234,173,20,116,35,128,185,29,150,73,208,18,228,225,29,14,191,88,42,98,205,6,202,189,150,227,158,248,207,10,99,204,48,131,132,83,163,116,129,177,13,250,94,43,251,10,119,42,204,41,101,26,218,5,44,197,15,11,171,123,128,93,157,51,91,194,192,73,196,87,49,106,151,52,82,130,41,74,254,188,188,0,196,10,206,89,87,57,10,104,84,226,90,140,210,27,68,238,48,212,197,24,133,25,190,217,27,152,222,115,176,51,70,132,122,2,69,211,92,25,130,160,33,58,69,150,203,173,243,177,130,127,98,196,108,241,138,175,145,45,168,97,217,107,42,108,142,5,54,1,226,41,104,149,253,236,182,160,235,68,222,160,176,204,20,130,163,109,183,246,116,170,157,111,108,145,169,129,105,175,228,191,17,253,168,190,234,114,246,168,82,219,172,129,204,175,72,63,240,171,173,80,185,18,250,99,114,250,113,132,94,185,41,191,170,17,12,43,225,124,206,199,135,46,146,126,5,178,53,34,7,148,93,217,64,228,205,232,231,42,110,227,227,72,86,63,126,20,147,105,217,64,86,224,108,145,212,246,208,77,64,13,254,205,142,196,77,9,92,42,51,54,151,31,183,46,63,227,235,147,228,62,253,130,61,46,73,104,62,56,59,157,92,80,117,200,226,11,60,155,211,124,148,150,74,95,116,120,23,36,183,152,249,2,69,243,93,22,36,4,195,76,157,233,229,65,26,45,38,100,49,165,205,128,190,64,173,74,253,207,89,48,135,52,114,132,232,42,37,206,9,79,212,172,202,188,200,255,35,79,19,78,83,174,212,53,215,101,203,157,114,189,83,56,164,14,184,61,231,44,255,174,91,170,35,87,67,108,143,221,216,155,105,88,78,91,97,84,208,195,29,136,4,16,80,191,66,141,149,250,66,20,50,194,8,60,6,147,54,102,235,171,212,18,111,57,245,46,138,76,151,62,245,114,232,67,76,238,232,183,98,74,252,205,42,205,25,7,125,44,49,43,181,65,203,232,141,208,154,77,171,143,181,140,221,105,28,101,199,92,187,246,109,167,210,99,119,204,111,233,170,93,137,76,47,130,108,159,242,210,30,116,30,100,193,140,37,68,123,131,192,178,137,147,104,48,62,137,20,153,55,59,172,106,67,203,79,73,76,78,162,124,48,22,0,140,198,236,223,78,59,29,48,35,33,26,69,229,85,61,130,239,222,159,150,78,48,169,113,249,168,171,187,23,134,216,197,102,209,234,238,190,14,168,71,223,131,160,178,242,141,16,45,190,188,66,166,110,241,121,50,210,106,178,190,240,80,139,174,10,204,70,100,128,105,53,124,232,36,95,45,64,152,86,34,8,240,121,219,39,106,167,194,23,201,137,94,145,196,32,75,20,71,144,77,198,55,49,140,110,9,235,213,47,168,100,230,204,158,83,162,196,32,153,119,54,100,240,152,98,172,64,17,230,141,41,169,194,121,249,248,7,162,168,241,224,249,55,16,245,26,208,115,115,42,235,136,235,205,163,165,199,124,218,86,99,94,75,134,77,78,203,138,157,77,128,171,88,107,45,108,185,216,218,195,24,43,76,157,26,173,35,24,73,130,205,246,58,79,243,152,77,12,199,54,10,212,76,226,123,184,108,10,151,103,146,169,203,25,255,11,77,149,218,80,115,163,87,202,53,66,113,66,144,212,147,205,7,73,5,195,64,160,122,127,102,84,84,132,122,16,30,7,227,125,87,44,236,104,173,31,241,131,26,12,186,167,107,131,253,14,132,43,154,68,191,226,161,109,33,213,80,163,147,79,46,98,183,233,108,50,0,42,132,141,113,208,48,168,174,65,176,18,253,254,23,1,47,99,251,116,28,243,66,73,235,123,156,114,154,37,223,214,243,237,44,230,53,224,245,196,76,78,169,194,250,2,82,83,175,186,187,86,123,57,199,179,244,30,139,173,96,57,186,129,105,74,37,30,245,32,252,44,49,59,235,67,100,225,194,169,159,101,245,61,168,52,227,95,109,158,181,190,128,210,130,174,121,82,181,92,12,169,250,218,101,189,127,247,165,68,250,87,207,141,186,181,9,211,136,183,233,86,61,194,121,152,197,115,99,10,213,216,244,123,60,162,165,159,230,57,206,74,217,127,239,150,24,93,32,185,157,74,69,28,33,190,149,149,169,130,250,66,21,72,125,49,212,99,125,129,202,137,76,131,74,196,174,1,10,195,236,191,213,74,185,23,200,81,170,246,2,40,211,148,239,194,169,154,254,44,247,25,133,124,15,6,29,167,158,105,9,255,191,124,70,183,159,101,193,130,6,34,213,61,100,119,13,177,199,128,2,177,11,100,43,224,228,244,208,6,59,132,131,35,148,94,255,27,135,132,71,38,136,101,211,40,119,152,76,156,68,113,24,208,145,231,162,12,80,204,184,14,171,129,57,109,7,103,25,132,247,25,253,158,211,237,231,55,101,211,217,80,28,236,185,233,184,64,190,112,226,86,147,177,61,95,0,106,235,190,99,15,125,127,4,209,112,68,161,105,0,245,59,227,217,209,154,101,246,6,202,99,46,229,109,234,245,93,151,182,134,173,95,98,92,79,56,230,254,136,74,31,246,169,162,92,163,60,232,230,191,149,15,230,252,127,159,140,233,84,81,115,209,232,179,204,151,250,147,49,142,19,96,131,242,209,150,13,169,253,113,20,147,190,43,189,198,184,126,23,244,147,67,237,105,127,173,167,209,154,78,58,161,221,170,17,172,95,116,122,127,99,127,69,167,49,126,23,157,37,58,117,68,177,151,185,65,25,95,142,106,161,187,142,44,200,163,76,149,115,161,155,73,24,170,144,12,44,116,239,43,205,46,29,167,84,135,235,207,37,84,68,232,143,68,59,158,23,110,149,153,62,179,96,208,177,25,13,25,252,215,70,134,163,167,13,178,156,171,65,47,157,97,25,163,75,0,98,10,212,112,74,187,77,2,174,166,29,86,164,249,228,29,83,119,39,33,67,38,35,214,144,233,126,211,107,186,246,27,209,9,115,134,48,56,88,28,249,232,148,110,75,125,136,217,10,175,32,192,166,187,4,63,18,233,65,59,78,243,245,16,6,99,110,208,236,65,203,214,132,202,88,85,227,56,106,110,26,231,31,241,3,127,73,74,7,244,200,14,37,72,89,176,19,165,184,118,93,225,120,253,92,90,247,34,128,14,132,61,181,4,10,173,206,0,28,58,44,182,226,49,169,153,241,99,205,103,141,150,14,73,47,57,157,225,135,179,12,6,168,253,83,251,32,190,36,90,118,122,195,91,117,152,222,240,138,198,17,49,71,206,197,235,180,206,18,57,141,210,9,184,234,92,177,124,230,86,84,244,212,88,69,249,214,219,85,47,18,224,10,98,220,34,240,49,101,104,129,142,15,90,130,51,50,24,142,212,73,179,128,215,225,241,75,246,189,225,75,12,92,7,79,213,134,57,176,158,131,197,170,243,90,218,186,131,216,105,181,215,149,110,237,139,50,92,231,13,203,181,170,151,112,56,146,130,198,37,136,78,9,253,246,182,11,98,215,117,9,118,220,179,123,251,117,170,219,167,121,4,94,187,86,221,28,235,2,94,85,5,54,98,8,45,200,56,99,94,196,12,214,156,43,178,197,132,190,101,138,198,57,109,26,5,237,115,226,6,226,213,242,70,126,243,17,35,160,151,82,170,39,196,141,158,189,85,131,162,117,106,191,10,137,158,7,109,0,186,85,65,201,206,130,186,114,130,117,57,31,247,237,75,37,20,155,208,67,182,50,242,77,233,161,129,248,217,122,216,116,83,65,127,244,176,116,38,185,163,30,234,67,247,235,209,67,247,37,19,107,209,67,3,96,143,180,144,221,120,97,64,99,10,104,66,149,234,71,104,148,177,150,47,228,139,189,117,47,52,89,189,27,221,170,254,214,43,154,137,213,99,127,36,195,166,104,54,56,175,186,175,181,126,117,41,48,175,15,56,151,155,18,120,22,150,16,253,114,159,239,141,213,137,237,202,226,228,91,50,232,243,147,74,202,90,26,135,61,4,3,187,27,180,9,214,0,90,213,162,147,104,189,186,1,179,160,233,130,159,12,237,145,205,178,27,184,76,104,158,193,91,245,102,159,75,138,118,192,230,16,153,149,103,47,111,171,166,52,173,190,237,222,68,55,107,247,158,116,98,223,79,15,74,131,39,48,221,129,81,186,78,122,152,188,217,86,107,93,41,83,244,234,186,134,235,2,30,115,45,166,178,74,79,109,211,103,151,182,121,28,205,112,84,73,40,196,115,133,197,182,47,154,56,136,161,126,69,158,231,129,211,24,26,16,183,17,43,169,121,165,225,171,3,214,42,192,178,153,241,178,109,196,129,182,213,187,87,121,230,18,221,235,54,207,238,222,216,82,176,4,0,171,213,211,38,76,235,8,39,139,254,90,23,114,131,172,127,203,41,84,246,185,139,149,190,163,211,13,229,30,198,169,156,158,48,158,5,153,10,190,165,214,146,93,103,110,128,226,97,145,147,116,86,166,219,152,178,143,208,64,241,122,36,211,130,65,205,113,180,181,136,197,5,178,127,194,113,179,178,146,176,215,74,72,84,101,23,13,206,225,147,113,163,167,91,124,207,203,27,234,16,27,80,93,40,221,240,54,36,123,177,190,193,183,240,115,151,97,236,239,100,99,234,201,25,29,233,26,107,225,74,77,192,118,241,33,219,144,108,61,155,116,116,161,174,188,163,190,251,50,237,145,11,201,38,197,215,195,141,185,85,161,85,196,165,38,59,207,145,133,166,170,201,189,4,167,123,148,58,156,180,220,9,90,129,174,47,49,214,27,239,77,199,23,93,219,28,111,207,203,245,138,90,164,176,84,23,225,218,47,134,213,59,241,227,196,1,78,222,50,88,30,17,18,155,223,197,43,46,227,186,253,45,119,237,242,8,59,234,148,113,39,191,106,47,223,53,12,91,186,52,1,138,107,6,53,175,216,82,160,49,249,119,144,112,45,230,105,2,107,87,249,223,217,158,83,12,154,216,31,69,151,62,69,99,147,174,100,202,191,182,59,118,235,69,57,208,81,172,146,4,77,74,155,122,85,36,46,197,236,15,99,219,28,136,198,92,191,203,203,190,18,221,113,145,112,211,107,34,167,103,56,55,243,175,213,86,234,219,46,15,85,70,91,193,216,237,2,85,205,25,199,5,170,230,221,169,174,187,68,221,239,130,26,55,84,101,244,98,85,0,48,139,249,47,233,176,195,190,130,220,70,183,70,25,60,27,140,233,90,58,61,177,36,59,174,221,217,116,166,144,242,27,35,208,245,66,94,187,45,186,220,196,54,37,227,226,227,111,198,196,26,127,44,162,179,137,45,125,87,119,229,231,13,86,254,85,3,243,130,121,121,235,111,235,79,28,112,16,206,203,122,207,233,130,144,215,122,147,125,67,239,195,149,200,203,59,211,77,230,91,152,237,213,194,198,59,219,215,112,207,101,58,95,244,109,165,138,205,201,53,176,218,149,146,60,45,178,16,171,91,74,72,144,221,98,246,30,68,183,21,32,79,89,2,69,143,129,242,255,65,119,139,233,234,239,103,52,25,249,233,237,91,196,175,43,118,119,108,190,17,14,85,157,83,141,198,106,171,26,201,216,113,122,143,179,7,200,5,177,238,209,87,101,220,251,59,214,8,24,65,107,149,207,84,57,197,59,205,182,10,178,166,139,148,121,105,169,176,244,179,100,117,236,96,117,47,143,2,18,152,106,107,253,218,87,125,211,242,111,122,157,101,52,173,37,49,46,221,229,204,232,127,192,179,107,144,27,11,204,160,237,169,100,218,160,154,246,105,38,127,69,192,144,215,40,167,127,158,160,25,221,210,248,186,51,19,158,254,11,31,109,84,211,196,111,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("10bb4f79-5b92-47ce-b685-8e404e4984b9"));
		}

		#endregion

	}

	#endregion

}
