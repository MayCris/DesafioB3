const PROXY_CONFIG = [
  {
    context: [
      "/GetCalculoDCB",
    ],
    target: "https://localhost:7114",
    secure: false
  }
]

module.exports = PROXY_CONFIG;
