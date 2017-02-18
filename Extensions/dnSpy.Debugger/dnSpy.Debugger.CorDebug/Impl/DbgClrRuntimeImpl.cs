﻿/*
    Copyright (C) 2014-2017 de4dot@gmail.com

    This file is part of dnSpy

    dnSpy is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    dnSpy is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with dnSpy.  If not, see <http://www.gnu.org/licenses/>.
*/

using System;
using dnSpy.Contracts.Debugger;
using dnSpy.Contracts.Debugger.DotNet;
using dnSpy.Contracts.Debugger.DotNet.CorDebug;

namespace dnSpy.Debugger.CorDebug.Impl {
	sealed class DbgClrRuntimeImpl : CorDebugRuntime {
		public override DbgProcess Process { get; }
		public override CorDebugRuntimeVersion Version { get; }
		public override string ClrFilename { get; }
		public override string RuntimeDirectory { get; }

		public override DbgModule[] Modules {
			get {
				throw new NotImplementedException();//TODO:
			}
		}

		public override DbgClrAppDomain[] AppDomains {
			get {
				throw new NotImplementedException();//TODO:
			}
		}

		public DbgClrRuntimeImpl(DbgProcess process, CorDebugRuntimeKind kind, string version, string clrPath, string runtimeDir) {
			if (version == null)
				throw new ArgumentNullException(nameof(version));
			Process = process ?? throw new ArgumentNullException(nameof(process));
			Version = new CorDebugRuntimeVersion(kind, version);
			ClrFilename = clrPath ?? throw new ArgumentNullException(nameof(clrPath));
			RuntimeDirectory = runtimeDir ?? throw new ArgumentNullException(nameof(runtimeDir));
		}

		protected override void CloseCore() {
			//TODO: Dispose of all DbgObject instances
		}
	}
}
