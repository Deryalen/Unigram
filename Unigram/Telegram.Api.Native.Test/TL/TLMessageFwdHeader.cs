// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL
{
	public partial class TLMessageFwdHeader : TLObject 
	{
		[Flags]
		public enum Flag : Int32
		{
			FromId = (1 << 0),
			ChannelId = (1 << 1),
			ChannelPost = (1 << 2),
		}

		public bool HasFromId { get { return Flags.HasFlag(Flag.FromId); } set { Flags = value ? (Flags | Flag.FromId) : (Flags & ~Flag.FromId); } }
		public bool HasChannelId { get { return Flags.HasFlag(Flag.ChannelId); } set { Flags = value ? (Flags | Flag.ChannelId) : (Flags & ~Flag.ChannelId); } }
		public bool HasChannelPost { get { return Flags.HasFlag(Flag.ChannelPost); } set { Flags = value ? (Flags | Flag.ChannelPost) : (Flags & ~Flag.ChannelPost); } }

		public Flag Flags { get; set; }
		public Int32? FromId { get; set; }
		public Int32 Date { get; set; }
		public Int32? ChannelId { get; set; }
		public Int32? ChannelPost { get; set; }

		public TLMessageFwdHeader() { }
		public TLMessageFwdHeader(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.MessageFwdHeader; } }

		public override void Read(TLBinaryReader from)
		{
			Flags = (Flag)from.ReadInt32();
			if (HasFromId) FromId = from.ReadInt32();
			Date = from.ReadInt32();
			if (HasChannelId) ChannelId = from.ReadInt32();
			if (HasChannelPost) ChannelPost = from.ReadInt32();
		}

		public override void Write(TLBinaryWriter to)
		{
			UpdateFlags();

			to.WriteInt32((Int32)Flags);
			if (HasFromId) to.WriteInt32(FromId.Value);
			to.WriteInt32(Date);
			if (HasChannelId) to.WriteInt32(ChannelId.Value);
			if (HasChannelPost) to.WriteInt32(ChannelPost.Value);
		}

		private void UpdateFlags()
		{
			HasFromId = FromId != null;
			HasChannelId = ChannelId != null;
			HasChannelPost = ChannelPost != null;
		}
	}
}