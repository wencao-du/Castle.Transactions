#region license

// Copyright 2009-2011 Henrik Feldt - http://logibit.se/
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//      http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

#endregion

using Castle.Services.Transaction.IO;
using Castle.Services.Transaction.Tests.Framework;
using NUnit.Framework;

namespace Castle.Services.Transaction.Tests
{
	[Ignore("Wait for RC")]
	public class DirectoryAdapter_NonTransactionalBehaviour : TxFTestFixtureBase
	{
		[Test]
		public void Exists()
		{
			IDirectoryAdapter d = new DirectoryAdapter(new MapPathImpl(), false, null);
			var path = Path.GetPathWithoutLastBit(d.MapPath("~/../../DirectoryAdapter_NonTransactionalBehaviour.cs"));
				// get directory instead
			Assert.That(d.Exists(path));
		}
	}
}