using System.Runtime.InteropServices;
using LibGit2Sharp.Core;

namespace LibGit2Sharp
{
    internal enum git_proxy_t
    {
        GIT_PROXY_NONE,
        GIT_PROXY_AUTO,
        GIT_PROXY_SPECIFIED,
    }

    [StructLayout(LayoutKind.Sequential)]
    internal unsafe struct GitProxyOptions
    {
        public uint version;
        public git_proxy_t type;
        public char* url;
        public NativeMethods.git_cred_acquire_cb credentials;
        public NativeMethods.git_transport_certificate_check_cb certificate_check;
        public void* payload;
    }
}
