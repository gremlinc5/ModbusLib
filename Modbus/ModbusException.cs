using System;
using System.Diagnostics;

namespace Osre.Modbus
{
   /// <summary>
   /// Modbus communication related exception
   /// </summary>
   [DebuggerDisplay("ErrorCode = {ErrorCode}")]
   public class ModbusException : Exception
   {
      /// <summary>
      /// Creates a new ModbusException from an message
      /// </summary>
      /// <param name="message">Message of the exception</param>
      public ModbusException(string message) :
         base(message)
      {
         ErrorCode = ModbusErrorCode.Unspecified;
      }

      /// <summary>
      /// Creates a new ModbusException from an error code
      /// </summary>
      /// <param name="errorCode">Error code</param>
      public ModbusException(ModbusErrorCode errorCode)
#if !NETMF
         : base(errorCode.ToString())
#endif
      {
         ErrorCode = errorCode;
      }

      /// <summary>
      /// Gets the modbus error code
      /// </summary>
      public ModbusErrorCode ErrorCode { get; private set; }
   }
}
