using System;
using System.Collections.Generic;

namespace CriadoresCaes_tA_B.Models {

   /// <summary>
   /// classe para permitir o transporte do Controller para a View, e vice-versa
   /// ir� transportar os dados das Fotografias e dos IDs do C�es que pertencem 
   /// � pessoa autenticada
   /// </summary>
   public class FotosCaes {

      /// <summary>
      /// lista de todas as fotografias de todos os c�es
      /// </summary>
      public ICollection<Fotografias> ListaFotografias { get; set; }

      /// <summary>
      /// lista dos IDs dos c�es que pertencem � pessoa autenticada
      /// </summary>
      public ICollection<int> ListaCaes { get; set; }

   }




   public class ErrorViewModel {
      public string RequestId { get; set; }
      public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
   }

}
