﻿//
// - DataArriveEventArgs.cs
// 
// Author:
//     Lucas Ontivero <lucasontivero@gmail.com>
// 
// Copyright 2013 Lucas E. Ontivero
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//  http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// <summary></summary>

using System;

namespace P2PNet.EventArgs
{
    public class DataArrivedEventArgs : System.EventArgs
    {
        private readonly byte[] _buffer;
        private readonly Guid _source;

        public DataArrivedEventArgs(Guid peerGuid, byte[] buffer)
        {
            _buffer = buffer;
            _source = peerGuid;
        }

        public byte[] Buffer
        {
            get { return _buffer; }
        }

        public Guid Source
        {
            get { return _source; }
        }
    }
}