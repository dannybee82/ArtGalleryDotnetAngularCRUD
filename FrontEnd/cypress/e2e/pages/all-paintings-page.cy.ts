describe('All Paintings Page', () => {    
  
  const MAX_PAINTINGS: number = 2;

  beforeEach(() => {
     cy.allPaintingsPage();
  });  
  
  it('Test API response', () => {
     // Wait for the intercepted request  
    cy.wait('@paintings').then((interception) => {  
      // Optional: Assert on the response  
      expect(interception?.response?.statusCode).to.equal(200);  
      expect(interception?.response?.body.items).to.have.length(2);  
    });
  });

  it('Test amount of paintings', () => {  
    // Check the UI - adjust based on your actual UI  
    cy.byTestId('paintings-amount').should('have.text', '2 paintings found'); 
  });  

  it('Count mat-cards in grid', () => {
    cy.byTestId('paintings-card-grid').find('mat-card').should('have.length', MAX_PAINTINGS);
  });

  it('Test images', () => {
    cy.wait(3000);

    cy.get('[data-cy=paintings-card-grid]').scrollIntoView();

    cy.byTestId('paintings-thumbnail-container').each(($thumbnail, $index) => {
      if($index === 0) {
        cy.wrap($thumbnail).find('img').should('not.exist');        
      } else {
        cy.wrap($thumbnail).find('img').should('exist').and('be.visible');        
      }
    });
  });

  it('Test Card titles', () => {
    let counter: number = 1;

    cy.byTestId('paintings-card-title').each($title => {
      expect($title.text()).to.equal(`Dummy Painting ${counter}`);
      counter++;
    });    
  });

  it('Test Card painters', () => {
    let counter: number = 1;

    cy.byTestId('paintings-subtitle').each($painter => {
      expect($painter.text()).to.equal(`Painter: Dummy Artist ${counter}`);
      counter++;
    });    
  });

  it('Test Card styles', () => {
    let counter: number = 1;

    cy.byTestId('paintings-style').each($style => {
      expect($style.text()).to.equal(`Style: Dummy Style ${counter}`);
      counter++;
    });    
  });

  it('Test Card years', () => {
    let counter: number = 2025;

    cy.byTestId('paintings-year').each($year => {      
      expect($year.text()).to.equal(`Year: ${counter}`);
      counter--;
    });
  });
  
  it('Buttons detail page', () => {
    // Get ALL buttons that contain a mat-icon with 'visibility'  
    cy.getMatIconButtons('visibility')
    .then(($buttons) => {  
      const buttonCount = $buttons.length;  
      cy.log(`Found ${buttonCount}`); // Debug log  
        
      for (let i = 0; i < buttonCount; i++) {  
        cy.visit('/');  
        cy.wait('@paintings');  
          
        // Re-query and get the specific button by index  
        cy.getMatIconButtonByIndex('visibility', i).click();  
            
        //Assertion  
        cy.url().should('include', `/painting-details/${i + 1}`);  
      }  
    });
  });

  it('Buttons edit page', () => {
    // Get ALL buttons that contain a mat-icon with 'edit'  
    cy.getMatIconButtons('edit')
    .then(($buttons) => {  
      const buttonCount = $buttons.length;  
      cy.log(`Found ${buttonCount} edit buttons`); // Debug log  
        
      for (let i = 0; i < buttonCount; i++) {  
        cy.visit('/');  
        cy.wait('@paintings');  
          
        // Re-query and get the specific button by index  
        cy.getMatIconButtonByIndex('edit', i).click();  
            
        //Assertion  
        cy.url().should('include', `/create-or-update-painting/${i + 1}`);  
      }  

      cy.visit('/');  
      cy.wait('@paintings'); 
    });
  });

});