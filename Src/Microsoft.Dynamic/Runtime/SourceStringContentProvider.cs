/* ****************************************************************************
 *
 * Copyright (c) Microsoft Corporation. 
 *
 * This source code is subject to terms and conditions of the Apache License, Version 2.0. A 
 * copy of the license can be found in the License.html file at the root of this distribution. If 
 * you cannot locate the  Apache License, Version 2.0, please send an email to 
 * dlr@microsoft.com. By using this source code in any fashion, you are agreeing to be bound 
 * by the terms of the Apache License, Version 2.0.
 *
 * You must not remove this notice, or any other, from this software.
 *
 *
 * ***************************************************************************/

using System;
using System.IO;
using System.Dynamic;
using Microsoft.Scripting.Utils;
using System.Text;

namespace Microsoft.Scripting {

    [Serializable]
    internal sealed class SourceStringContentProvider : TextContentProvider {
        private readonly string _code;

        internal SourceStringContentProvider(string code) {
            ContractUtils.RequiresNotNull(code, nameof(code));

            _code = code;
        }

        public override SourceCodeReader GetReader() {
            return new SourceCodeReader(new StringReader(_code), null);
        }
    }
}
