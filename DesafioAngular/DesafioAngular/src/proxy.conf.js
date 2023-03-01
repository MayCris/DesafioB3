const PROXY_CONFIG = [
  {
    context: [
      "/GetCalculoDCB",
    ],
    target: "https://localhost:5089",
    secure: false
  }
]

module.exports = PROXY_CONFIG;
