﻿namespace NAudio.MediaFoundation
{
	public enum MF_FILE_ACCESSMODE
	{
		MF_ACCESSMODE_READ,
		MF_ACCESSMODE_WRITE,
		MF_ACCESSMODE_READWRITE
	}
	public enum MF_FILE_OPENMODE
	{
		MF_OPENMODE_FAIL_IF_NOT_EXIST,
		MF_OPENMODE_FAIL_IF_EXIST,
		MF_OPENMODE_RESET_IF_EXIST,
		MF_OPENMODE_APPEND_IF_EXIST,
		MF_OPENMODE_DELETE_IF_EXIST
	}
	public enum MF_FILE_FLAGS
	{
		MF_FILEFLAGS_NONE,
		MF_FILEFLAGS_NOBUFFERING,
		MF_FILEFLAGS_ALLOW_WRITE_SHARING
	}
}