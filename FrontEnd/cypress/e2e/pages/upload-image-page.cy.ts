describe('Image Upload Tests', () => {  

  beforeEach(() => {    
    cy.uploadImagePage();
  });  
  
  it('upload an image and display preview', () => {  
    // Prepare a test image file  
    const fileName = 'cypress/fixtures/test-image-001.jpg';  
      
    // Upload file (note: using native Cypress selectFile method)
    cy.byTestId('upload-image-input').selectFile(fileName, {force: true});  
    
    // Verify file name is displayed  
    //cy.byTestId('upload-image-button').should('contain', fileName);  
      
    // Verify image preview is displayed  
    cy.byTestId('upload-image-preview')  
      .should('be.visible')  
      .and(($img) => {  
        // Check that image has loaded  
        expect(($img[0] as HTMLImageElement).naturalWidth).to.be.greaterThan(0); 
      });  
      
    // Verify preview URL starts with data:image  
    cy.byTestId('upload-image-preview')    
      .should('have.attr', 'src')  
      .and('include', 'data:image');  
  });  
  
  it('upload file via button click', () => {  
    const fileName = 'cypress/fixtures/test-image-001.jpg';  
    
    // Force upload on the hidden input (note: using native Cypress selectFile method)
    cy.byTestId('upload-image-input').selectFile(fileName, { force: true });    

    // Click the styled button (not the hidden input)  
    cy.byTestId('upload-image-button').click();  
            
    // Verify upload was successful  
    cy.byTestId('upload-image-preview').should('be.visible');  
    //cy.get('.file-name').should('contain', fileName);  

    cy.uploadFormData('/UploadImage/UploadImage', 'test-image-001.jpg', [], []).then(result => {  
      expect(result.status).to.eq(200);  
      expect(result.response.success).to.be.true;       
    });  
  
    cy.wait('@upload');
  });  

  it('use remove button', () => {
    // Prepare a test image file  
    const fileName = 'cypress/fixtures/test-image-001.jpg';  
      
    // Upload file (note: using native Cypress selectFile method)
    cy.byTestId('upload-image-input').selectFile(fileName, {force: true});  
    cy.wait(1000);

    // Verify image preview is displayed  
    cy.byTestId('upload-image-preview')  
      .should('be.visible')  
      .and(($img) => {  
        // Check that image has loaded  
        expect(($img[0] as HTMLImageElement).naturalWidth).to.be.greaterThan(0); 
      }); 

    cy.getMatStrokedButtons('delete').click();

    cy.get('div.row').find('img.upload-image-preview')  
      .should('not.exist');
  });

});