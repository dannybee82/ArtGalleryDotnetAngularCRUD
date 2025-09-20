describe('Image Upload Tests', () => {  

  beforeEach(() => {    
    cy.uploadImagePage();
  });  
  
  it('upload an image and display preview', () => {  
    // Prepare a test image file  
    const fileName = 'test-image.jpg';  
      
    // Upload file using the plugin  
    cy.byTestId('upload-image-input').attachFile(fileName);  
      
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
    const fileName = 'test-image.jpg';  
    
    // Force upload on the hidden input  
    cy.byTestId('upload-image-input').attachFile(fileName, { force: true });    

    // Click the styled button (not the hidden input)  
    cy.byTestId('upload-image-button').click();  
            
    // Verify upload was successful  
    cy.byTestId('upload-image-preview').should('be.visible');  
    //cy.get('.file-name').should('contain', fileName);  

    cy.uploadFormData('/UploadImage/UploadImage', 'test-image.jpg', [], []).then(result => {  
      expect(result.status).to.eq(200);  
      expect(result.response.success).to.be.true;       
    });  
  
    cy.wait('@upload');
  });  

  it('use remove button', () => {
    // Prepare a test image file  
    const fileName = 'test-image.jpg';  
      
    // Upload file using the plugin  
    cy.byTestId('upload-image-input').attachFile(fileName);  

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