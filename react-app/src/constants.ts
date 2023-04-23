const PROD_BACKEND_API_URL = "musicmanagement130901.azurewebsites.net";
const DEV_BACKEND_API_URL = "http://localhost:5203/api";

export const BACKEND_API_URL =
	process.env.NODE_ENV === "development" ? DEV_BACKEND_API_URL : PROD_BACKEND_API_URL;