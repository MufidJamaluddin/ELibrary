module.exports = {
  "roots": [
    "./src"
  ],
  "testMatch": [
    "**/__tests__/**/*.+(ts|tsx|js)",
    "**/?(*.)+(spec|test).+(ts|tsx|js)"
  ],
  "transform": {
    "^.+\\.(ts|tsx)$": "ts-jest",
    "^.+\\.(jpg|jpeg|png|gif|eot|otf|webp|svg|ttf|woff|woff2|mp4|webm|wav|mp3|m4a|aac|oga)$": "./assetTransformer.js",
    "^.+\\.(css|sass|less)$": "./assetTransformer.js"
  },
  "coverageThreshold": {
    "global": {
      "branches": 30,
      "functions": 30,
      "lines": 30,
      "statements": -10
    }
  },
  "coverageReporters":[
    "cobertura"
  ],
  "coverageDirectory":"./../../test_results/UITests/"
}