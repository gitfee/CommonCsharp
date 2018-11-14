 if (!string.IsNullOrEmpty(userName))
  {
      webReq.Credentials = new NetworkCredential(userName, Encrptor.Decrypt(password));
  }
  else
  {
      if (context != null)
      {
          webReq.UseDefaultCredentials = true;
      }
      else
      {

          webReq.Credentials = CredentialCache.DefaultCredentials;
      }
  }
