describe('Update Style Page', () => {

    beforeEach(() => {
        cy.updateStylePage();
    });

    it('Form exists', () => {
        cy.get('form').should('exist', true);
    });

    it('Test existence and values of form fields', () => {        
        cy.wait('@styleById');
        cy.wait(1000);

         cy.byTestId('style-crud-name')
            .should('exist', true)
            .should('have.attr', 'formcontrolname', 'name') 
            .should('have.value', 'Dummy Style 4'); 
        
        cy.byTestId('style-crud-description')
            .should('exist', true)
            .should('have.attr', 'formcontrolname', 'description')
            .should('have.value', 'Dummy Style 4 Description'); 
    });

    it('Test Update Style', () => {
        cy.wait('@styleById');
        cy.wait(1000);

        //Fill form fields.
        //Common issue with Angular Material => use { force: true }        
        cy.byTestId('style-crud-name').clear({ force: true }).type('Dummy Style 4 Update');

        //Fill text area.
        //Common issue with Angular Material => use { force: true }
        cy.byTestId('style-crud-description').clear({ force: true }).type('Dummy Style 4 Description Update');
        
        //Get button and click.
        cy.getMatRaisedButtons('save').click();

        // Wait for and verify the intercepted request
        cy.wait('@updateStyle').then((interception) => {  
            // Assert the modified request body  
            expect(interception.request.body).to.have.property('id', 4);
            expect(interception.request.body).to.have.property('name', 'Dummy Style 4 Update');  
            expect(interception.request.body).to.have.property('description', 'Dummy Style 4 Description Update');

            cy.wait('@allStyles');
            cy.url().should('include', '/all-styles');
        });  
    });

    it('Test cancel button', () => {
        cy.getMatRaisedButtons('cancel').click();

        cy.wait('@allStyles');
        cy.url().should('include', '/all-styles');        
        cy.visit('/create-or-update-style/4');
    });

});