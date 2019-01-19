/******************************************************************************
 * Spine Runtimes Software License v2.5
 *
 * Copyright (c) 2013-2016, Esoteric Software
 * All rights reserved.
 *
 * You are granted a perpetual, non-exclusive, non-sublicensable, and
 * non-transferable license to use, install, execute, and perform the Spine
 * Runtimes software and derivative works solely for personal or internal
 * use. Without the written permission of Esoteric Software (see Section 2 of
 * the Spine Software License Agreement), you may not (a) modify, translate,
 * adapt, or develop new applications using the Spine Runtimes or otherwise
 * create derivative works or improvements of the Spine Runtimes or (b) remove,
 * delete, alter, or obscure any trademarks or any copyright, trademark, patent,
 * or other intellectual property or proprietary rights notices on or in the
 * Software, including any copy thereof. Redistributions in binary or source
 * form must include this license and terms.
 *
 * THIS SOFTWARE IS PROVIDED BY ESOTERIC SOFTWARE "AS IS" AND ANY EXPRESS OR
 * IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES OF
 * MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO
 * EVENT SHALL ESOTERIC SOFTWARE BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL,
 * SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO,
 * PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES, BUSINESS INTERRUPTION, OR LOSS OF
 * USE, DATA, OR PROFITS) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER
 * IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE)
 * ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE
 * POSSIBILITY OF SUCH DAMAGE.
 *****************************************************************************/

using System;

namespace Spine3_7_83 {
	/// <summary>Stores the current pose values for an Event.</summary>
	public class Event {
		internal readonly EventData data;
		internal readonly float time;
		internal int intValue;
		internal float floatValue;
		internal string stringValue;
		internal float volume;
		internal  float balance;

		public EventData Data { get { return data; } }
		/// <summary>The animation time this event was keyed.</summary>
		public float Time { get { return time; } }

		public int Int { get { return intValue; } set { intValue = value; } }
		public float Float { get { return floatValue; } set { floatValue = value; } }
		public string String { get { return stringValue; } set { stringValue = value; } }

		public float Volume { get { return volume; } set { volume = value; } }
		public float Balance { get { return balance; } set { balance = value; } }

		public Event (float time, EventData data) {
			if (data == null) throw new ArgumentNullException("data", "data cannot be null.");
			this.time = time;
			this.data = data;
		}

		override public string ToString () {
			return this.data.Name;
		}
	}
}
