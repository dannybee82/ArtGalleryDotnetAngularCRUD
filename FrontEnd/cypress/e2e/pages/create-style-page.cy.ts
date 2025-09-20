describe('Create Style Page', () => {

    beforeEach(() => {
        cy.createStylePage();
    });

    it('Form exists', () => {
        cy.get('form').should('exist', true);
    });

    it('Test existence and names form fields', () => {
        cy.byTestId('style-crud-name')
            .should('exist', true)
            .should('have.attr', 'formcontrolname', 'name')
            .should('have.value', '');
        
        cy.byTestId('style-crud-description')
            .should('exist', true)
            .should('have.attr', 'formcontrolname', 'description')
            .should('have.value', '');
    });

    it('Test Create style', () => {
        //Fill form fields.
        //Common issue with Angular Material => use { force: true }
        cy.byTestId('style-crud-name').clear({ force: true }).type('Dummy Style 4');

        //Fill text area.
        //Common issue with Angular Material => use { force: true }
        cy.byTestId('style-crud-description').clear({ force: true }).type('Dummy Style 4 Description');

        //Get button and click.
        cy.getMatRaisedButtons('save').click();

        // Wait for and verify the intercepted request
        cy.wait('@createStyle').then((interception) => {  
            // Assert the modified request body  
            expect(interception.request.body).to.have.property('name', 'Dummy Style 4');  
            expect(interception.request.body).to.have.property('description', 'Dummy Style 4 Description');              

            cy.wait('@allStyles');
            cy.url().should('include', '/all-styles');
        });  
    });

    it('Test cancel button', () => {
        cy.getMatRaisedButtons('cancel').click();

        cy.wait('@allStyles');
        cy.url().should('include', '/all-styles');        
        cy.visit('/create-or-update-style');
    });

});