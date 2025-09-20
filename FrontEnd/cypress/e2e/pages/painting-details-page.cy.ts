describe('Painting Details Page', () => {

    beforeEach(() => {
        cy.paintingDetailsPage();
    });

    it('Test Column existence', () => {
        cy.byTestId('painting-details-column').should('exist', true);
    });

    it('Test has Image', () => {
        cy.get('img').should('exist', true);
        cy.get('img').each(image => {
            expect(image.attr('alt')).to.equal('Dummy Painting 3');
        });
    });

    it('Test painting title h3', () => {
        cy.byTestId('painting-details-name')
            .should('exist', true)
            .should('have.text', 'Dummy Painting 3');
    });

    it('Test painting description', () => {
        cy.byTestId('painting-details-description')
            .should('exist', true)
            .should('have.text', 'Dummy description 3');
    });

    it('Test artist name', () => {
        cy.byTestId('painting-details-artist-name')
            .should('exist', true)
            .should('have.text', 'Artist Dummy Artist 3 ');
    });

    it('Test year', () => {
        cy.byTestId('painting-details-year')
            .should('exist', true)
            .should('have.text', 'Year 2023 ');
    });

    it('Test style name', () => {
        cy.byTestId('painting-details-artist-style')
            .should('exist', true)
            .should('have.text', 'Style Dummy Style 3 ');
    });

    it('Test about artist', () => {
        cy.byTestId('painting-details-artist-about')
            .should('exist', true)
            .should('have.text', 'About Dummy Artist 3 (1982)');
    });

    it('Test about artist description', () => {
        cy.byTestId('painting-details-artist-description')
            .should('exist', true)
            .should('have.text', 'Dummy Artist description');
    });

    it('Test painting style ', () => {
        cy.byTestId('painting-details-about-style-name')
            .should('exist', true)
            .should('have.text', 'About Dummy Style 3');
    });
    
    it('Test painting style description', () => {
        cy.byTestId('painting-details-about-style-description')
            .should('exist', true)
            .should('have.text', 'Dummy Style Description 3');
    });

});