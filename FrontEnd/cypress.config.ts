import { defineConfig } from 'cypress'

export default defineConfig({

  e2e: {
    baseUrl: 'http://angularapp:80',
    specPattern: 'cypress/e2e/**/*.cy.ts',  
    supportFile: 'cypress/support/e2e.ts',  
    video: false,  
  },
    
})