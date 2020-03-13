export const environment = {
  production: false,
  INVOICE_SERVICE_ENDPOINT: window["env"]["INVOICE_SERVICE_ENDPOINT"] || "default",
  debug: window["env"]["debug"] || false
};