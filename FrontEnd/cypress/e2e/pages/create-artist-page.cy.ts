describe('Create Artist Page', () => {

    beforeEach(() => {
        cy.createArtistPage();
    });

    it('Form exists', () => {
        cy.get('form').should('exist', true);
    });

    it('Test existence and names form fields', () => {
        cy.byTestId('artist-crud-name')
            .should('exist', true)
            .should('have.attr', 'formcontrolname', 'name')
            .should('have.value', '');
        
        cy.byTestId('artist-crud-description')
            .should('exist', true)
            .should('have.attr', 'formcontrolname', 'description')
            .should('have.value', '');
        
        cy.byTestId('artist-crud-yearOfBirth')
            .should('exist', true)
            .should('have.attr', 'formcontrolname', 'yearOfBirth')
            .should('have.value', '1980');
        
        cy.byTestId('artist-crud-yearOfDeath')
            .should('exist', true)
            .should('have.attr', 'formcontrolname', 'yearOfDeath')
            .should('have.value', '');
    });

    it('Test Create Artist', () => {
        //Fill form fields.
        //Common issue with Angular Material => use { force: true }
        cy.byTestId('artist-crud-name').clear({ force: true }).type('Dummy Artist 4');

        //Common issue with Angular Material => use { force: true }
        cy.byTestId('artist-crud-yearOfBirth').clear({ force: true }) .type('1998');

        //Skipped dateOfDeath field.

        //Fill text area.
        //Common issue with Angular Material => use { force: true }
        cy.byTestId('artist-crud-description').clear({ force: true }).type('Dummy Artist 4 Description');

        //Get button and click.
        cy.getMatRaisedButtons('save').click();

        // Wait for and verify the intercepted request
        cy.wait('@createArtist').then((interception) => {  
            // Assert the modified request body  
            expect(interception.request.body).to.have.property('name', 'Dummy Artist 4');  
            expect(interception.request.body).to.have.property('description', 'Dummy Artist 4 Description');  
            expect(interception.request.body).to.have.property('yearOfBirth', 1998);  
            expect(interception.request.body).to.not.have.property('yearOfDeath', undefined);

            cy.wait('@allArtists');
            cy.url().should('include', '/all-artists');
        });  
    });

    it('Test cancel button', () => {
        cy.getMatRaisedButtons('cancel').click();

        cy.wait('@allArtists');
        cy.url().should('include', '/all-artists');        
        cy.visit('/create-or-update-artist');
    });

});