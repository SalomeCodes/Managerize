(function(window) {
    window.env = window.env || {};
  
    // Environment variables
    window["env"]["INVOICE_SERVICE_ENDPOINT"] = "${INVOICE_SERVICE_ENDPOINT}";
    window["env"]["debug"] = "${DEBUG}";
  })(this);