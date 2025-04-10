using Microsoft.EntityFrameworkCore.Storage;
using static Google.Protobuf.Compiler.CodeGeneratorResponse.Types;

namespace HikeBookAPI.Models
{
    public class Feature
    {
        public Geometry Geometry { get; set; }
        public Properties Properties { get; set; }
    }




}
