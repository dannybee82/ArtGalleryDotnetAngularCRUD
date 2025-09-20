declare namespace Cypress {  
  interface Chainable {  

    byTestId<E extends Node = HTMLElement>(
      id: string,
      options?: Partial<
        Cypress.Loggable & Cypress.Timeoutable & Cypress.Withinable & Cypress.Shadow
      >,
    ): Cypress.Chainable<JQuery<E>>;

    getMatIconButtons<E extends Node = HTMLElement>(
      icon: string
    ): Cypress.Chainable<JQuery<E>>;

    getMatIconButtonByIndex<E extends Node = HTMLElement>(
      icon: string,
      index: number
    ): Cypress.Chainable<JQuery<E>>;

    getMatRaisedButtons<E extends Node = HTMLElement>(
      icon: string
    ): Cypress.Chainable<JQuery<E>>;

    getMatRaisedButtonByIndex<E extends Node = HTMLElement>(
      icon: string,
      index: number
    ): Cypress.Chainable<JQuery<E>>;

    getMatStrokedButtons<E extends Node = HTMLElement>(
      icon: string
    ): Cypress.Chainable<JQuery<E>>;

    getMatStrokedButtonByIndex<E extends Node = HTMLElement>(
      icon: string,
      index: number
    ): Cypress.Chainable<JQuery<E>>;

    allPaintingsPage(): Chainable<void>;

    createPaintingPage(): Chainable<void>;

    updatePaintingPage(): Chainable<void>;
    
    paintingDetailsPage(): Chainable<void>;
    
    allArtistsPage(): Chainable<void>;

    createArtistPage(): Chainable<void>;
    
    updateArtistPage(): Chainable<void>;

    allStylesPage(): Chainable<void>;

    createStylePage(): Chainable<void>;

    updateStylePage(): Chainable<void>;

    uploadImagePage(): Chainable<void>;

    uploadFormData(url: string, fileFixture: string, additionalData: object[], headers: object[]): Chainable<any>;

  }  
}